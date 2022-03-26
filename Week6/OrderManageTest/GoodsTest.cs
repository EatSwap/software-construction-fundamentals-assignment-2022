using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManageCLI;

namespace OrderManageTest; 

[TestClass]
public class GoodsTest {
	[TestMethod]
	public void Goods() {
		var g1 = new Goods("Product 1", 1.01);
		var g2 = new Goods("Product 1", 1.01);
		var g3 = new Goods("Product 2", 1.02);
		var g4 = new Goods("Product 1", 1.02);
		
		Assert.AreEqual(g1, g2);
		Assert.AreNotEqual(g1, g3);
		Assert.AreNotEqual(g1, g4);
		Assert.AreNotEqual(g1, null);
		Assert.AreNotEqual(g1, "String");
		Assert.AreNotEqual(g1, new object());
		
		Assert.IsTrue(g1.Equals(g2));
		Assert.IsTrue(g1.Equals(g1));
		Assert.IsFalse(g1.Equals(g3));
		Assert.IsFalse(g1.Equals(g4));
		Assert.IsFalse(g1.Equals(null));
		
		// GetHashCode
		Assert.AreEqual(g1.GetHashCode(), g2.GetHashCode());
		Assert.AreNotEqual(g1.GetHashCode(), g3.GetHashCode());
		Assert.AreNotEqual(g1.GetHashCode(), g4.GetHashCode());
		Assert.AreNotEqual(g4.GetHashCode(), g3.GetHashCode());

		Assert.AreEqual($"Goods[Name={g1.Name},Price={g1.Price}]", g1.ToString());
	}
}