namespace OrderManageCLI; 

public class Customer {
	public string Name { get; set; }

	public Customer(string name = "") {
		this.Name = name;
	}

	public override string ToString() {
		return $"Customer[{Name}]";
	}

	public override int GetHashCode() {
		return Name.GetHashCode();
	}
	
	public override bool Equals(object? obj) {
		return obj is Customer rhs && Name.Equals(rhs.Name);
	}
}
