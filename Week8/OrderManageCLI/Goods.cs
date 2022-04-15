namespace OrderManageCLI;

public class Goods {
	public Goods(string name = "", double price = 0.0) {
		this.Name = name;
		this.Price = price;
	}

	public Goods() {
		this.Name = "";
		this.Price = 0.0;
	}

	public string Name { get; set; }

	public double Price { get; set; }

	public override string ToString() => $"Goods[Name={this.Name},Price={this.Price}]";

	public override int GetHashCode() => this.Name.GetHashCode() ^ this.Price.GetHashCode();

	public override bool Equals(object? obj) => obj is Goods rhs && this.Name.Equals(rhs.Name) && this.Price.Equals(rhs.Price);

	public Goods Clone() => new(this.Name, this.Price);
}
