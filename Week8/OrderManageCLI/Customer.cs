namespace OrderManageCLI;

public class Customer {
	public Customer() {
		Name = "";
		Address = "";
	}
	
	public Customer(string name = "", string address = "") {
		Name = name;
		Address = address;
	}

	public string Name { get; set; }

	public string Address { get; set; }

	public override string ToString() {
		return $"Customer[Name=[{Name}],Address[{Address}]]";
	}

	public override int GetHashCode() {
		return Name.GetHashCode() ^ Address.GetHashCode();
	}

	public override bool Equals(object? obj) {
		return obj is Customer rhs && Name.Equals(rhs.Name) && Address.Equals(rhs.Address);
	}
}