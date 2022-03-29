using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManageCLI;

namespace OrderManageTest;

[TestClass]
public class OrderServiceTest {
	[TestMethod]
	public void OrderServiceT() {
		var os = new OrderService();
		var order = new Order(new Customer("Name 1", "Address 1"), DateTime.Now, new OrderDetails("Product 1", 1, 1));
		os.AddOrder(order);
		
		var findOrder = os.FindOrder(order.OrderId);
		
		Assert.IsNotNull(findOrder);
		// Assert.AreEqual(order, findOrder);
		Assert.AreEqual(1, os.Count);
		Assert.IsTrue(os.HasOrder(order.OrderId));
		Assert.IsTrue(os.HasOrder(order));
		
		// Add duplicate order
		var order2 = new Order(new Customer("Name 1", "Address 1"), DateTime.Now, new OrderDetails("Product 1", 1, 1));
		try {
			os.AddOrder(order2);
			Assert.Fail("Should throw exception");
		} catch (Exception e) {
			Assert.AreEqual("OrderService: Order already exists", e.Message);
		}
		
		// Add different order with same id
		var order3 = new Order(new Customer("Name 2", "Address 2"), DateTime.Now, new OrderDetails("Product 2", 2, 2));
		order3.OrderId = order.OrderId;
		try {
			os.AddOrder(order3);
			Assert.Fail("Should throw exception");
		} catch (Exception e) {
			Assert.AreEqual("OrderService: Duplicated OrderId", e.Message);
		}

		// Add another
		var order4 = new Order(new Customer("Name 3", "Address 3"), DateTime.Now, new OrderDetails("Product 3", 3, 3));
		os.AddOrder(order4);
		Assert.AreEqual(2, os.Count);
		Assert.IsTrue(os.HasOrder(order4.OrderId));
		Assert.IsTrue(os.HasOrder(order4));
		
		// Traversal
		foreach (var o in os) {
			Assert.IsNotNull(o);
			Assert.IsTrue(o.Equals(order) || o.Equals(order4));
		}
		
		// Normal removal
		try {
			os.RemoveOrder(order.OrderId);
		} catch (Exception ignored) {
			Assert.Fail("Should not throw exception");
		}

		// Multiple removal
		try {
			os.RemoveOrder(order.OrderId);
			Assert.Fail("Should throw exception");
		} catch (Exception e) {
			Assert.AreEqual("OrderService: Order not found", e.Message);
		}
		
		Assert.AreEqual(1, os.Count);
		
		// Remove order4
		os.RemoveOrder(order4);
		Assert.AreEqual(0, os.Count);
		
		// Remove order4 again
		try {
			os.RemoveOrder(order4);
			Assert.Fail("Should throw exception");
		} catch (Exception e) {
			Assert.AreEqual("OrderService: Order not found", e.Message);
		}
		
		// Add some, then clear
		os.AddOrder(order);
		os.AddOrder(order4);
		Assert.AreEqual(2, os.Count);
		os.RemoveAllOrders();
		Assert.AreEqual(0, os.Count);
		
		// More orders
		var rnd = new Random();
		var randomOrders = new Order[100];
		for (int i = 0; i < 100; ++i) {
			randomOrders[i] = new Order(new Customer($"Name {i}", $"Address {i}"), new DateTime(1923 + rnd.Next(100), 1 + rnd.Next(12), 1 + rnd.Next(28)), new OrderDetails($"Product {i}", rnd.NextDouble(), rnd.Next(100)));
			os.AddOrder(randomOrders[i]);
		}
		
		// ... then sort
		os.SortOrders(Comparer<Order>.Create((x, y) => x.TotalPrice().CompareTo(y.TotalPrice())));
		for (int i = 1; i < 100; ++i) {
			Assert.IsTrue(os.Orders[i - 1].TotalPrice() <= os.Orders[i].TotalPrice());
		}
		
		// ... then sort reversely
		os.SortOrders(Comparer<Order>.Create((x, y) => y.TotalPrice().CompareTo(x.TotalPrice())));
		for (int i = 1; i < 100; ++i) {
			Assert.IsTrue(os.Orders[i - 1].TotalPrice() >= os.Orders[i].TotalPrice());
		}
		
		// Find orders which price > 50.0
		// Should be ordered in TotalPrice() DESC
		var findOrders = os.Find(o => o.TotalPrice() > 50.0);
		Console.WriteLine("Find orders which price < 50.0, count: " + findOrders.Count);
		Console.WriteLine("Order 0: " + findOrders[0].TotalPrice());
		for (int i = 1; i < findOrders.Count; ++i) {
			Assert.IsTrue(findOrders[i - 1].TotalPrice() > 50.0);
			Assert.IsTrue(findOrders[i - 1].TotalPrice() >= findOrders[i].TotalPrice());
			Console.WriteLine("Order " + i + ": " + findOrders[i].TotalPrice());
		}
		
		// Again, but > 40.0, and in TotalPrice() ASC
		var findOrders2 = os.Find(o => o.TotalPrice() > 40.0, (x, y) => x.TotalPrice().CompareTo(y.TotalPrice()));
		for (int i = 1; i < findOrders2.Count; ++i) {
			Assert.IsTrue(findOrders2[i - 1].TotalPrice() > 40.0);
			Assert.IsTrue(findOrders2[i - 1].TotalPrice() <= findOrders2[i].TotalPrice());
		}
		
		// Find by customer
		int select = rnd.Next(100);
		var findOrders3 = os.Find(randomOrders[select].Customer);
		Assert.AreEqual(1, findOrders3.Count);
		Assert.AreEqual(randomOrders[select], findOrders3[0]);

		// Find by Goods
		select = rnd.Next(100);
		var findOrders4 = os.Find(randomOrders[select].OrderDetails[0].Item);
		Assert.AreEqual(1, findOrders4.Count);
		Assert.AreEqual(randomOrders[select], findOrders4[0]);
		
		// By DateTime Range
		var dt1949 = new DateTime(1949, 10, 1);
		var dt1999 = new DateTime(1999, 10, 1);
		var findOrders5 = os.FindByRange(dt1949, dt1999);
		foreach (var i in findOrders5) {
			Assert.IsTrue(i.OrderTime >= dt1949 && i.OrderTime < dt1999);
		}
		
		// By TotalPrice() Range
		var findOrders6 = os.FindByRange(30.0, 70.0);
		foreach (var i in findOrders6) {
			Assert.IsTrue(i.TotalPrice() >= 30.0 && i.TotalPrice() < 70.0);
		}
		
		// Modify Order
		var newOrder0 = randomOrders[0];
		newOrder0.OrderTime = new DateTime(2025, 2, 28);
		var ok = os.ModifyOrder(randomOrders[0].OrderId, newOrder0);
		Assert.IsTrue(ok);
		var findOrder0 = os.FindOrder(randomOrders[0].OrderId);
		Assert.IsNotNull(findOrder0);
		Assert.AreEqual(newOrder0, findOrder0);
		// ... a non-exist one
		ok = os.ModifyOrder(114514, newOrder0);
		Assert.IsFalse(ok);
		
		// ... by exact order
		var newOrder1 = randomOrders[1];
		newOrder1.OrderTime = new DateTime(2025, 2, 28);
		ok = os.ModifyOrder(randomOrders[1], newOrder1);
		Assert.IsTrue(ok);
		var findOrder1 = os.FindOrder(randomOrders[1].OrderId);
		Assert.IsNotNull(findOrder1);
		Assert.AreEqual(newOrder1, findOrder1);
		// ... a non-exist one
		ok = os.ModifyOrder(order3, newOrder1);
		Assert.IsFalse(ok);
		
		// Delete Order
		Assert.IsNotNull(os.FindOrder(randomOrders[2].OrderId));
		ok = os.DeleteOrder(randomOrders[2].OrderId);
		Assert.IsTrue(ok);
		Assert.IsNull(os.FindOrder(randomOrders[2].OrderId));
		// ... again
		ok = os.DeleteOrder(randomOrders[2].OrderId);
		Assert.IsFalse(ok);
		
		// ... by exact order
		Assert.IsNotNull(os.FindOrder(randomOrders[3].OrderId));
		ok = os.DeleteOrder(randomOrders[3]);
		Assert.IsTrue(ok);
		Assert.IsNull(os.FindOrder(randomOrders[3].OrderId));
		// ... again
		ok = os.DeleteOrder(randomOrders[3]);
		Assert.IsFalse(ok);

		// Action
		var dt1979 = new DateTime(1979, 10, 1);
		var toAdd = new OrderDetails("haha", 123.45, 67);
		os.Action(o => o.OrderTime < dt1979, o => o.AddRecord(toAdd));
		foreach (var i in os) {
			Assert.IsTrue(i.OrderTime >= dt1979 || i.OrderDetails.Contains(toAdd));
		}
		
		// ... by Customer
		var cToFind = randomOrders[rnd.Next(100)].Customer;
		os.Action(cToFind, o => o.OrderTime = new DateTime(2027, 2, 28));
		foreach (var i in os) {
			Assert.IsTrue(!cToFind.Equals(i.Customer) || i.OrderTime == new DateTime(2027, 2, 28));
		}
		
		// ... by Goods
		var item2Find = toAdd.Item;
		os.Action(item2Find, o => o.OrderTime = new DateTime(2029, 3, 31));
		foreach (var i in os) {
			Assert.IsTrue(!i.HasGoods(item2Find) || i.OrderTime == new DateTime(2029, 3, 31));
		}
		
		// Equals
		Assert.IsTrue(os.Equals(os));
		
		// (De)Serialise
		ok = os.Export("export.xml");
		Assert.IsTrue(ok);
		var os2 = OrderService.Import("export.xml");
		Assert.IsNotNull(os2);
		Assert.AreEqual(os, os2);
	}
}