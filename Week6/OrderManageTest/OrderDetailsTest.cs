using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManageCLI;

namespace OrderManageTest; 

[TestClass]
public class OrderDetailsTest {
	[TestMethod]
	public void OrderDetails() {
		var g = new Goods("gugu", 1145.14);
		var od1 = new OrderDetails(g, 1919810);
		var od2 = new OrderDetails("gugu", 1145.14, 1919810);
		var od3 = new OrderDetails("guagua", 191.9810, 114514);

		// Equals
		Assert.AreEqual(od1, od2);
		Assert.AreNotEqual(od1, od3);
		
		// GetHashCode
		Assert.AreEqual(od1.GetHashCode(), od2.GetHashCode());
		Assert.AreNotEqual(od2.GetHashCode(), od3.GetHashCode());
		
		// ToString
		Assert.AreEqual(od2.ToString(), $"OrderDetails[Item=({od2.Item.ToString()}),Count={od2.Count}]");
		
		// Price
		Assert.AreEqual(od1.Item.Price * od1.Count, od1.Price);
		Assert.AreEqual(od3.Item.Price * od3.Count, od3.Price);
	}
}