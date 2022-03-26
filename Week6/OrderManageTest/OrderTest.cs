﻿using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManageCLI;

namespace OrderManageTest; 

[TestClass]
public class OrderTest {
	[TestMethod]
	public void OrderBasic() {
		var dt = DateTime.Now;
		var c = new Customer("Tom", "123456789");
		var c2 = new Customer("Tom", "123456780");
		var p = new Goods("apple", 10.1);
		var p2 = new Goods("C#", 1.10);

		var order1 = new Order(c, dt, new OrderDetails(p, 12));
		var order2 = new Order(c, dt, new OrderDetails(p, 12));
		order2.OrderId = order1.OrderId;
		
		var order3 = new Order(c, dt, new OrderDetails(p, 11));
		var order4 = new Order(c, dt, new OrderDetails(p2, 12));
		var order5 = new Order(c2, dt, new OrderDetails(p, 12));
		var order6 = new Order(c, dt, new OrderDetails(p, 12));

		Assert.AreEqual(order1, order2);
		Assert.AreNotEqual(order1, order3);
		Assert.AreNotEqual(order1, order4);
		Assert.AreNotEqual(order1, order5);
		Assert.AreNotEqual(order1, order6);
		
		Assert.AreEqual(order1.GetHashCode(), order2.GetHashCode());
		Assert.AreNotEqual(order1.GetHashCode(), order3.GetHashCode());
		Assert.AreNotEqual(order1.GetHashCode(), order4.GetHashCode());
		Assert.AreNotEqual(order1.GetHashCode(), order5.GetHashCode());
		Assert.AreNotEqual(order1.GetHashCode(), order6.GetHashCode());
		
		Assert.AreEqual(order1.ToString(), order2.ToString());
		Assert.AreNotEqual(order1.ToString(), order3.ToString());
		Assert.AreNotEqual(order1.ToString(), order4.ToString());
		Assert.AreNotEqual(order1.ToString(), order5.ToString());
		Assert.AreNotEqual(order1.ToString(), order6.ToString());
		
		Assert.AreEqual(dt, order1.OrderTime);
	}
	
	private string RandomString() => Guid.NewGuid().ToString();

	public void OrderFindAndTraverse() {
		var dt = DateTime.Now;
		var c = new Customer("Tom", "123456789");
		var o = new Order(c, dt);

		var randEngine = new Random();
		
		for (int i = 0; i < 10; i++) {
			var p = new Goods(RandomString(), randEngine.NextDouble());
			var toAdd = new OrderDetails(p, 1 + randEngine.Next(100));
			o.AddRecord(toAdd);
		}
	}
}