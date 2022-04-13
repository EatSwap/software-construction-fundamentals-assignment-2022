namespace OrderManageCLI;

public class OrderDetails {
	public OrderDetails(Goods item, int count) {
		Item = item;
		Count = count;
	}

	public OrderDetails(string itemName, double itemPrice, int count) {
		Item = new Goods(itemName, itemPrice);
		Count = count;
	}
	
	public OrderDetails() {
		Item = new Goods();
		Count = 0;
	}

	public Goods Item { get; set; }

	public int Count { get; set; }

	public double Price => Item.Price * Count;

	public double ItemPrice => Item.Price;



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