namespace OrderManageCLI;

public class Goods {
	public Goods(string name = "", double price = 0.0) {
		Name = name;
		Price = price;
	}
	
	public Goods() {
		Name = "";
		Price = 0.0;
	}

	public string Name { get; set; }

	public double Price { get; set; }

	public override string ToString() {
		return $"Goods[Name={Name},Price={Price}]";
	}

	public override int GetHashCode() {
		return Name.GetHashCode() ^ Price.GetHashCode();
	}

	public override bool Equals(object? obj) {
		return obj is Goods rhs && Name.Equals(rhs.Name) && Price.Equals(rhs.Price);
	}
}