namespace OrderManageCLI; 

public class OrderDetails {
	public Goods Item { get; set; }
	
	public int Count { get; set; }

	public double Price => Item.Price * Count;

	public override bool Equals(object? obj) {
		return obj is OrderDetails rhs && Item.Equals(rhs.Item) && Count == rhs.Count;
	}

	public override int GetHashCode() {
		return Item.GetHashCode() ^ Count;
	}

	public override string ToString() {
		return $"OrderDetails[Item=({Item.ToString()}),Count={Count}]";
	}
}
