namespace OrderManageCLI;

public class Customer {
	public Customer() {
		Name = "";
		Address = "";
	}
	
	public Customer(string? name = null, string? address = null) {
		Name = name ?? string.Empty;
		Address = address ?? string.Empty;
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
	
	public Customer Clone() {
		return new Customer(Name, Address);
	}
}