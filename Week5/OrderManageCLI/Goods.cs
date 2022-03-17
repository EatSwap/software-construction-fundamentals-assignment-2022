namespace OrderManageCLI;

public class Goods {
	public string Name { get; set; }
	
	public double Price { get; set; }

	public Goods(string name = "") {
		this.Name = name;
	}

	public override string ToString() {
		return $"Merchandise[{Name}]";
	}

	public override int GetHashCode() {
		return Name.GetHashCode() ^ Price.GetHashCode();
	}

	public override bool Equals(object? obj) {
		if (obj == null)
			return false;
		
		Goods? rhs = obj as Goods;

		return rhs != null && this.Name.Equals(rhs.Name) && this.Price.Equals(rhs.Price);
	}
}
