namespace OrderManageCLI;

using System.Collections;
using System.Text;

public class Order {
	private static long _orderNum;

	public Order(Customer? c, DateTime orderTime, params OrderDetails[] details) {
		this.Customer = c == null ? new Customer() : c;
		this.OrderDetails = new List<OrderDetails>();
		foreach (OrderDetails detail in details)
			this.OrderDetails.Add(detail);
		this.OrderId = ++_orderNum;
		this.OrderTime = orderTime;
	}

	public Order() {
		this.OrderDetails = new List<OrderDetails>();
		this.Customer = new Customer();
		this.OrderId = -1;
		this.OrderTime = new DateTime();
	}

	public Customer Customer { get; set; }

	public long OrderId { get; set; }

	public DateTime OrderTime { get; set; }

	public List<OrderDetails> OrderDetails { get; set; }

	public int Count => this.OrderDetails.Count;

	public double Price => this.TotalPrice();

	public string CustomerName => this.Customer.Name;

	public string CustomerAddress => this.Customer.Address;

	public string PriceStr => this.Price.ToString("0.00");

	public IEnumerator GetEnumerator() => this.OrderDetails.GetEnumerator();

	public double TotalPrice() {
		var ret = 0.0;
		this.OrderDetails.ForEach(od => ret += od.Price);
		return ret;
	}

	public bool HasGoods(Goods? g) {
		return this.OrderDetails.Any(i => i.Item.Equals(g));
	}
	
	public bool HasItemName(string name) {
		return this.OrderDetails.Any(i => i.Item.Name.Equals(name));
	}

	public void AddRecord(OrderDetails od) {
		if (this.OrderDetails.Contains(od))
			throw new Exception($"Order #{this.OrderId} AddRecord: Specified order details already exists!");
		this.OrderDetails.Add(od);
	}

	public void RemoveRecord(OrderDetails od) {
		if (this.OrderDetails.Contains(od))
			this.OrderDetails.Remove(od);
		else
			throw new Exception($"Order #{this.OrderId} RemoveRecord: OrderDetails not found");
	}

	public bool EqualsIgnoreId(object? obj) => obj is Order rhs && this.Customer.Equals(rhs.Customer) && this.OrderDetails.All(rhs.OrderDetails.Contains) && this.OrderDetails.Count == rhs.OrderDetails.Count;

	public override bool Equals(object? obj) => obj is Order rhs && this.Customer.Equals(rhs.Customer) && this.OrderDetails.All(rhs.OrderDetails.Contains) && this.OrderDetails.Count == rhs.OrderDetails.Count && this.OrderId == rhs.OrderId;

	public override int GetHashCode() {
		int ret = this.Customer.GetHashCode() ^ this.OrderId.GetHashCode();
		foreach (OrderDetails i in this.OrderDetails)
			ret ^= i.GetHashCode();
		return ret;
	}

	public override string ToString() {
		int n = this.OrderDetails.Count;
		var detailsStr = new StringBuilder();
		for (var i = 0; i < n; ++i) {
			if (i > 0)
				detailsStr.Append(',');
			detailsStr.Append($"#{i}=[{this.OrderDetails[i].ToString()}]");
		}

		return $"Order[ID={this.OrderId},Customer=[{this.Customer.ToString()}],OrderTime=[{this.OrderTime.ToString("R")}],OrderDetails=[{detailsStr.ToString()}],TotalPrice={this.TotalPrice()}]";
	}

	public Order Clone() {
		var ret = new Order(this.Customer.Clone(), this.OrderTime);
		foreach (OrderDetails i in this.OrderDetails)
			ret.AddRecord(i.Clone());
		ret.OrderId = this.OrderId;
		--_orderNum;
		return ret;
	}
}
