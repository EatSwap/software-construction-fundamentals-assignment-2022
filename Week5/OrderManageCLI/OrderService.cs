using System.Collections;

namespace OrderManageCLI; 

public class OrderService {
	private List<Order> _orders = new List<Order>();
	
	public List<Order> Orders => _orders;
	
	public void AddOrder(Order order) {
		if (_orders.Contains(order))
			throw new Exception("OrderService: Order already exists");
		if (_orders.FindIndex(o => o.OrderId == order.OrderId) != -1)
			throw new Exception("OrderService: Duplicated OrderId");
		_orders.Add(order);
	}
	
	public void RemoveOrder(Order order) {
		if (!_orders.Contains(order))
			throw new Exception("OrderService: Order not found");
		_orders.Remove(order);
	}
	
	public void RemoveOrder(int index) {
		if (index < 0 || index >= _orders.Count)
			throw new IndexOutOfRangeException($"Index {index} is out of range: [0, {_orders.Count})");
		_orders.RemoveAt(index);
	}
	
	public void RemoveAllOrders() {
		_orders.Clear();
	}
	
	public void SortOrders(IComparer<Order> comparer) {
		_orders.Sort(comparer);
	}
	
	public List<Order> FindOrders(Func<Order, bool> match) {
		return _orders.Where(match).OrderBy(o => o.TotalPrice()).ToList();
	}

	// Find by customer
	public List<Order> FindOrders(Customer c) {
		return this.FindOrders(o => c.Equals(o.Customer));
	}
	
	// Find by product
	public List<Order> FindOrders(Goods g) {
		return this.FindOrders(o => o.HasGoods(g));
	}
	
	// Find by ID
	public Order? FindOrder(int id) {
		var ret = _orders.Where(o => o.OrderId == id).ToList();
		return ret.Count == 0 ? null : ret[0];
	}
	
	public bool HasOrder(int id) {
		return this.FindOrder(id) != null;
	}

	public bool ModifyOrder(int id, Order newOrder) {
		var idx = _orders.FindIndex(o => o.OrderId == id);
		if (idx < 0)
			return false;
		_orders[idx] = newOrder;
		return true;
	}
	
	public bool ModifyOrder(Order oldOrder, Order newOrder) {
		var idx = _orders.FindIndex(o => o.Equals(oldOrder));
		if (idx < 0)
			return false;
		_orders[idx] = newOrder;
		return true;
	}
	
	public bool DeleteOrder(int id) {
		var idx = _orders.FindIndex(o => o.OrderId == id);
		if (idx < 0)
			return false;
		_orders.RemoveAt(idx);
		return true;
	}
	
	public bool DeleteOrder(Order order) {
		var idx = _orders.FindIndex(o => o.Equals(order));
		if (idx < 0)
			return false;
		_orders.RemoveAt(idx);
		return true;
	}

	public int Action(Func<Order, bool> match, Action<Order> action) {
		int cnt = 0;
		foreach (var order in _orders.Where(match)) {
			action(order);
			cnt++;
		}
		return cnt;
	}
	
	public int Action(Customer c, Action<Order> action) {
		return Action(o => c.Equals(o.Customer), action);
	}
	
	public int Action(Goods g, Action<Order> action) {
		return Action(o => o.HasGoods(g), action);
	}
	
	public IEnumerator<Order> GetEnumerator() {
		return _orders.GetEnumerator();
	}
}
