using System.Collections;
using System.Text;

namespace OrderManageCLI; 

public class Order : IEnumerable {
	private static long orderNum = 0;
	
	private readonly Customer _customer;

	public Customer Customer => _customer;

	private readonly long _orderId;
	
	public long OrderId => _orderId;

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

	public Order(Customer? c, params OrderDetails[] details) {
		_customer = c == null ? new Customer() : c;
		_orderDetailsList = new List<OrderDetails>();
		foreach (var detail in details) {
			_orderDetailsList.Add(detail);
		}
		_orderId = ++orderNum;
	}

	public override bool Equals(object? obj) {
		return obj is Order rhs && _customer.Equals(rhs._customer) &&
		       _orderDetailsList.All(rhs._orderDetailsList.Contains) &&
		       _orderDetailsList.Count == rhs._orderDetailsList.Count;
	}

	public override int GetHashCode() {
		int ret = _customer.GetHashCode();
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
		return $"Order[Customer=[{_customer.ToString()}],OrderDetails=[{detailsStr.ToString()}],TotalPrice={TotalPrice()}]";
	}
}
