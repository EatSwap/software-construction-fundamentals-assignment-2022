using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManageCLI;

namespace OrderManageTest; 

[TestClass]
public class CustomerTest {
	[TestMethod]
	public void Customer() {
		var c1 = new Customer("Name 1", "Address 1");
		var c2 = new Customer("Name 1", "Address 1");
		var c3 = new Customer("Name 2", "Address 1");
		var c4 = new Customer("Name 1", "Address 2");
		
		Assert.AreEqual(c1, c2);
		Assert.AreNotEqual(c1, c3);
		Assert.AreNotEqual(c1, c4);
		Assert.AreNotEqual(c1, null);
		Assert.AreNotEqual(c1, "String");
		Assert.AreNotEqual(c1, new object());
		
		Assert.IsTrue(c1.Equals(c2));
		Assert.IsTrue(c1.Equals(c1));
		Assert.IsFalse(c1.Equals(c3));
		Assert.IsFalse(c1.Equals(c4));
		Assert.IsFalse(c1.Equals(null));
		Assert.IsFalse(c1.Equals("String"));
		Assert.IsFalse(c1.Equals(new object()));
		
		Assert.AreEqual(c1.GetHashCode(), c2.GetHashCode());
		Assert.AreNotEqual(c1.GetHashCode(), c3.GetHashCode());
		Assert.AreNotEqual(c1.GetHashCode(), c4.GetHashCode());
		
		Assert.AreEqual(c1.ToString(), "Customer[Name=[Name 1],Address[Address 1]]");
		
		Assert.AreEqual(c1.Name, "Name 1");
		Assert.AreEqual(c1.Address, "Address 1");
	}
}