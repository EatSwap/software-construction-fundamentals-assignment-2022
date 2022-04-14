namespace OrderManageCLI;

public class OrderDetails {
	public OrderDetails(Goods item, int count) {
		this.Item = item;
		this.Count = count;
	}

	public OrderDetails(string itemName, double itemPrice, int count) {
		this.Item = new Goods(itemName, itemPrice);
		this.Count = count;
	}

	public OrderDetails() {
		this.Item = new Goods();
		this.Count = 0;
	}

	public Goods Item { get; set; }

	public int Count { get; set; }

	public double Price => this.Item.Price * this.Count;

	public double UnitPrice => this.Item.Price;

	public string ItemName => this.Item.Name;

	public string PriceStr => this.Price.ToString("0.00");

	public string UnitPriceStr => this.UnitPrice.ToString("0.00");

	public override bool Equals(object? obj) => obj is OrderDetails rhs && this.Item.Equals(rhs.Item) && this.Count == rhs.Count;

	public override int GetHashCode() => this.Item.GetHashCode() ^ this.Count;

	public override string ToString() => $"OrderDetails[Item=({this.Item.ToString()}),Count={this.Count}]";

	public OrderDetails Clone() => new OrderDetails(this.Item.Clone(), this.Count);
}
