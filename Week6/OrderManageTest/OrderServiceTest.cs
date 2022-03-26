using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManageCLI;

namespace OrderManageTest;

[TestClass]
public class OrderServiceTest {
	[TestMethod]
	public void OrderService() {
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
	}
}