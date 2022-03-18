namespace OrderManageCLI; 

public class OrderService {
	private List<Order> _orders = new List<Order>();
	
	public List<Order> Orders => _orders;
	
	public void AddOrder(Order order) {
		if (_orders.Contains(order))
			throw new Exception("OrderService: Order already exists");
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
	
	public void Action(Func<Order, bool> match, Action<Order> action) {
		foreach (var order in _orders.Where(match))
			action(order);
	}
	
	public void Action(Customer c, Action<Order> action) {
		Action(o => c.Equals(o.Customer), action);
	}
	
	public void Action(Goods g, Action<Order> action) {
		Action(o => o.HasGoods(g), action);
	}
	
}
