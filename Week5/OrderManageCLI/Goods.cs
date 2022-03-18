namespace OrderManageCLI;

public class Goods {
	public string Name { get; set; }
	
	public double Price { get; set; }

	public Goods(string name = "") {
		this.Name = name;
	}

	public override string ToString() {
		return $"Goods[{Name}]";
	}

	public override int GetHashCode() {
		return Name.GetHashCode() ^ Price.GetHashCode();
	}

	public override bool Equals(object? obj) {
		return obj is Goods rhs && Name.Equals(rhs.Name) && Price.Equals(rhs.Price);
	}
}
