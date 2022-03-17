using System.Collections;
using System.Text;

namespace OrderManageCLI; 

public class Order : IEnumerable {
	private Customer _customer;

	public Customer Customer => _customer;

	private List<OrderDetails> _orderDetailsList;

	public IEnumerator GetEnumerator() {
		return _orderDetailsList.GetEnumerator();
	}

	public double TotalPrice() {
		double ret = 0.0;
		foreach (var i in _orderDetailsList) {
			ret += i.Price;
		}
		return ret;
	}

	public Order(Customer? c, params OrderDetails[] details) {
		_customer = c == null ? new Customer() : c;
		_orderDetailsList = new List<OrderDetails>();
		foreach (var detail in details) {
			_orderDetailsList.Add(detail);
		}
	}

	public override bool Equals(object? obj) {
		if (obj == null)
			return false;
		Order? rhs = obj as Order;
		return rhs != null && this._customer.Equals(rhs._customer) &&
		       this._orderDetailsList.All(rhs._orderDetailsList.Contains) &&
		       this._orderDetailsList.Count == rhs._orderDetailsList.Count;
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
			detailsStr.AppendFormat("#{0}=[{1}]", i, _orderDetailsList[i].ToString());
		}

		return $"Order[Customer=[{_customer.ToString()}],OrderDetails=[{detailsStr.ToString()}],TotalPrice={TotalPrice()}]";
	}
}
