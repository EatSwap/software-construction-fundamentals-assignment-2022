namespace OrderManageCLI; 

public class OrderDetails {
	public Goods Item { get; set; }
	
	public int Count { get; set; }

	public double Price => Item.Price * Count;

	public override bool Equals(object? obj) {
		if (obj == null)
			return false;
		OrderDetails? rhs = obj as OrderDetails;
		return rhs != null && this.Item.Equals(rhs.Item) && this.Count == rhs.Count;
	}

	public override int GetHashCode() {
		return Item.GetHashCode() ^ Count;
	}

	public override string ToString() {
		return $"OrderDetails[Item=({Item.ToString()}),Count={Count}]";
	}
}
