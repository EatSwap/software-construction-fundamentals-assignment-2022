using System.Linq.Dynamic.Core;
using System.Xml.Serialization;

namespace OrderManageCLI;

[Serializable]
public class OrderService {
	public List<Order> Orders { get; } = new();
	
	public int Count => Orders.Count;

	public void AddOrder(Order order) {
		if (Orders.Where(o => o.EqualsIgnoreId(order)).ToList().Count > 0)
			throw new ArgumentException("OrderService: Order already exists");
		if (Orders.FindIndex(o => o.OrderId == order.OrderId) != -1)
			throw new ArgumentException("OrderService: Duplicated OrderId");
		Orders.Add(order);
	}

	public void RemoveOrder(Order? order) {
		if (order == null || !Orders.Contains(order))
			throw new ArgumentException("OrderService: Order not found");
		Orders.Remove(order);
	}
	
	public void RemoveOrder(long orderId) {
		var o = FindOrder(orderId);
		if (o == null)
			throw new ArgumentException("OrderService: Order not found");
		RemoveOrder(o);
	}
	
	public void RemoveAllOrders() {
		Orders.Clear();
	}

	public void SortOrders(IComparer<Order> comparer) {
		Orders.Sort(comparer);
	}

	public List<Order> Find(Func<Order, bool> match, string orderBy = "TotalPrice() DESC") {
		return Orders.Where(match).AsQueryable().OrderBy(orderBy).ToList();
	}

	public List<Order> Find(Func<Order, bool> match, Comparison<Order> sortFunc) {
		var ret = Orders.Where(match).ToList();
		ret.Sort(sortFunc);
		return ret;
	}

	// Find by customer
	public List<Order> Find(Customer c) {
		return Find(o => c.Equals(o.Customer));
	}

	// Find by product
	public List<Order> Find(Goods g) {
		return Find(o => o.HasGoods(g));
	}

	// Search any order in [begin, end)
	public List<Order> FindByRange(DateTime begin, DateTime end) {
		return Find(o => o.OrderTime >= begin && o.OrderTime < end);
	}

	// Search any order in [begin, end)
	public List<Order> FindByRange(double begin, double end) {
		return Find(o => o.TotalPrice() >= begin && o.TotalPrice() < end);
	}


	// Find by ID
	public Order? FindOrder(long id) {
		var ret = Orders.Where(o => o.OrderId == id).ToList();
		return ret.Count == 0 ? null : ret[0];
	}

	public bool HasOrder(long id) {
		return FindOrder(id) != null;
	}
	
	public bool HasOrder(Order? order) {
		return order != null && Orders.Contains(order);
	}

	public bool ModifyOrder(long id, Order newOrder) {
		var idx = Orders.FindIndex(o => o.OrderId == id);
		if (idx < 0)
			return false;
		Orders[idx] = newOrder;
		return true;
	}

	public bool ModifyOrder(Order oldOrder, Order newOrder) {
		var idx = Orders.FindIndex(o => o.EqualsIgnoreId(oldOrder));
		if (idx < 0)
			return false;
		Orders[idx] = newOrder;
		return true;
	}

	public bool DeleteOrder(long id) {
		var idx = Orders.FindIndex(o => o.OrderId == id);
		if (idx < 0)
			return false;
		Orders.RemoveAt(idx);
		return true;
	}

	public bool DeleteOrder(Order order) {
		var idx = Orders.FindIndex(o => o.EqualsIgnoreId(order));
		if (idx < 0)
			return false;
		Orders.RemoveAt(idx);
		return true;
	}

	public int Action(Func<Order, bool> match, Action<Order> action) {
		var cnt = 0;
		foreach (var order in Orders.Where(match)) {
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
		return Orders.GetEnumerator();
	}

	protected bool Equals(OrderService other) {
		return Orders.All(other.Orders.Contains) && other.Orders.Count == Orders.Count;	
	}

	public override bool Equals(object? obj) {
		if (ReferenceEquals(null, obj)) return false;
		if (ReferenceEquals(this, obj)) return true;
		if (obj.GetType() != this.GetType()) return false;
		return Equals((OrderService) obj);
	}

	public override int GetHashCode() {
		return Orders.GetHashCode();
	}

	public bool Export(string fileName) {
		try {
			var formatter = new XmlSerializer(typeof(OrderService));
			using var stream = new FileStream(fileName, FileMode.Create);
			formatter.Serialize(stream, this);
			return true;
		} catch {
			return false;
		}
	}
	
	public static OrderService? Import(string fileName) {
		try {
			var formatter = new XmlSerializer(typeof(OrderService));
			using var stream = new FileStream(fileName, FileMode.Open);
			return formatter.Deserialize(stream) as OrderService;
		} catch {
			return null;
		}
	}
}