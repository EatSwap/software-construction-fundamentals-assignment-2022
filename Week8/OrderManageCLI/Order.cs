using System.Collections;
using System.Text;

namespace OrderManageCLI;

public class Order {
	private static long _orderNum = 0;

	private List<OrderDetails> _orderDetailsList;

	public Order(Customer? c, DateTime orderTime, params OrderDetails[] details) {
		Customer = c == null ? new Customer() : c;
		_orderDetailsList = new List<OrderDetails>();
		foreach (var detail in details) _orderDetailsList.Add(detail);
		OrderId = ++_orderNum;
		OrderTime = orderTime;
	}

	public Order() {
		_orderDetailsList = new List<OrderDetails>();
		Customer = new Customer();
		OrderId = -1;
		OrderTime = new DateTime();
	}

	public Customer Customer { get; set; }

	public long OrderId { get; set; }

	public DateTime OrderTime { get; set; }

	public List<OrderDetails> OrderDetails {
		get => _orderDetailsList;
		set => _orderDetailsList = value;
	}

	public int Count => _orderDetailsList.Count;

	public double Price => this.TotalPrice();

	public string CustomerName => this.Customer.Name;

	public string CustomerAddress => this.Customer.Address;

	public string PriceStr => this.Price.ToString("0.00");

	public IEnumerator GetEnumerator() {
		return _orderDetailsList.GetEnumerator();
	}

	public double TotalPrice() {
		var ret = 0.0;
		_orderDetailsList.ForEach(od => ret += od.Price);
		return ret;
	}

	public bool HasGoods(Goods? g) {
		return _orderDetailsList.Any(i => i.Item.Equals(g));
	}

	public void AddRecord(OrderDetails od) {
		if (_orderDetailsList.Contains(od))
			throw new Exception($"Order #{OrderId} AddRecord: Specified order details already exists!");
		_orderDetailsList.Add(od);
	}

	public void RemoveRecord(OrderDetails od) {
		if (_orderDetailsList.Contains(od))
			_orderDetailsList.Remove(od);
		else
			throw new Exception($"Order #{OrderId} RemoveRecord: OrderDetails not found");
	}

	public bool EqualsIgnoreId(object? obj) {
		return obj is Order rhs && Customer.Equals(rhs.Customer) &&
		       _orderDetailsList.All(rhs._orderDetailsList.Contains) &&
		       _orderDetailsList.Count == rhs._orderDetailsList.Count;
	}

	public override bool Equals(object? obj) {
		return obj is Order rhs && Customer.Equals(rhs.Customer) &&
		       _orderDetailsList.All(rhs._orderDetailsList.Contains) &&
		       _orderDetailsList.Count == rhs._orderDetailsList.Count &&
		       OrderId == rhs.OrderId;
	}

	public override int GetHashCode() {
		var ret = Customer.GetHashCode() ^ OrderId.GetHashCode();
		foreach (var i in _orderDetailsList)
			ret ^= i.GetHashCode();
		return ret;
	}

	public override string ToString() {
		var n = _orderDetailsList.Count;
		var detailsStr = new StringBuilder();
		for (var i = 0; i < n; ++i) {
			if (i > 0)
				detailsStr.Append(',');
			detailsStr.Append($"#{i}=[{_orderDetailsList[i].ToString()}]");
		}

		return $"Order[ID={OrderId},Customer=[{Customer.ToString()}],OrderTime=[{OrderTime.ToString("R")}],OrderDetails=[{detailsStr.ToString()}],TotalPrice={TotalPrice()}]";
	}
	
	public Order Clone() {
		var ret = new Order(Customer.Clone(), OrderTime);
		foreach (var i in _orderDetailsList)
			ret.AddRecord(i.Clone());
		ret.OrderId = this.OrderId;
		--_orderNum;
		return ret;
	}
}