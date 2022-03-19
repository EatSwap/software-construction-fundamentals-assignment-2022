using System.Collections;
using System.Text;

namespace OrderManageCLI; 

public class Order : IEnumerable {
	private static long _orderNum = 0;

	public Customer Customer { get; set; }

	private readonly long _orderId;
	
	public long OrderId => _orderId;
	
	public DateTime OrderTime { get; set; }

	private List<OrderDetails> _orderDetailsList;

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
			throw new Exception($"Order #{_orderId} AddRecord: Specified order details already exists!");
		_orderDetailsList.Add(od);
	}

	public void RemoveRecord(OrderDetails od) {
		if (_orderDetailsList.Contains(od))
			_orderDetailsList.Remove(od);
		else
			throw new Exception($"Order #{_orderId} RemoveRecord: OrderDetails not found");
	}

	public Order(Customer? c, DateTime orderTime, params OrderDetails[] details) {
		Customer = c == null ? new Customer() : c;
		_orderDetailsList = new List<OrderDetails>();
		foreach (var detail in details) {
			_orderDetailsList.Add(detail);
		}
		_orderId = ++_orderNum;
		OrderTime = orderTime;
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
		       _orderId == rhs._orderId;
	}

	public override int GetHashCode() {
		int ret = Customer.GetHashCode();
		foreach (var i in _orderDetailsList)
			ret ^= i.GetHashCode();
		return ret;
	}

	public override string ToString() {
		int n = _orderDetailsList.Count;
		var detailsStr = new StringBuilder();
		for (int i = 0; i < n; ++i) {
			if (i > 0)
				detailsStr.Append(',');
			detailsStr.Append($"#{i}=[{_orderDetailsList[i].ToString()}]");
		}
		return $"Order[ID={_orderId},Customer=[{Customer.ToString()}],OrderTime=[{OrderTime.ToString("R")}],OrderDetails=[{detailsStr.ToString()}],TotalPrice={TotalPrice()}]";
	}
}
