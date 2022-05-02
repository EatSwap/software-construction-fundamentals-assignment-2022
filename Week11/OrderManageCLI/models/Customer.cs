namespace OrderManageCLI.models;

public class Customer {
	public Customer() {
		this.Name = "";
		this.Address = "";
	}

	public Customer(string? name = null, string? address = null) {
		this.Name = name ?? string.Empty;
		this.Address = address ?? string.Empty;
	}

	public long Id { get; set; }
	
	public string Name { get; set; }

	public string Address { get; set; }

	public override string ToString() => $"Customer[Name=[{this.Name}],Address[{this.Address}]]";

	public override int GetHashCode() => this.Name.GetHashCode() ^ this.Address.GetHashCode();

	public override bool Equals(object? obj) => obj is Customer rhs && this.Name.Equals(rhs.Name) && this.Address.Equals(rhs.Address);

	public Customer Clone() => new(this.Name, this.Address);
}
