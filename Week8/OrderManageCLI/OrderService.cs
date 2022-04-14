namespace OrderManageCLI;

using System.Linq.Dynamic.Core;
using System.Xml.Serialization;

[Serializable]
public class OrderService {
	public List<Order> Orders { get; } = new();

	public int Count => this.Orders.Count;

	public void AddOrder(Order order) {
		if (this.Orders.Where(o => o.EqualsIgnoreId(order)).ToList().Count > 0)
			throw new ArgumentException("OrderService: Order already exists");
		if (this.Orders.FindIndex(o => o.OrderId == order.OrderId) != -1)
			throw new ArgumentException("OrderService: Duplicated OrderId");
		this.Orders.Add(order);
	}

	public void RemoveOrder(Order? order) {
		if (order == null || !this.Orders.Contains(order))
			throw new ArgumentException("OrderService: Order not found");
		this.Orders.Remove(order);
	}

	public void RemoveOrder(long orderId) {
		Order? o = this.FindOrder(orderId);
		if (o == null)
			throw new ArgumentException("OrderService: Order not found");
		this.RemoveOrder(o);
	}

	public void RemoveAllOrders() {
		this.Orders.Clear();
	}

	public void SortOrders(IComparer<Order> comparer) {
		this.Orders.Sort(comparer);
	}

	public List<Order> Find(Func<Order, bool> match, string orderBy = "TotalPrice() DESC") => this.Orders.Where(match).AsQueryable().OrderBy(orderBy).ToList();

	public List<Order> Find(Func<Order, bool> match, Comparison<Order> sortFunc) {
		var ret = this.Orders.Where(match).ToList();
		ret.Sort(sortFunc);
		return ret;
	}

	// Find by customer
	public List<Order> Find(Customer c) {
		return this.Find(o => c.Equals(o.Customer));
	}

	// Find by product
	public List<Order> Find(Goods g) {
		return this.Find(o => o.HasGoods(g));
	}

	// Search any order in [begin, end)
	public List<Order> FindByRange(DateTime begin, DateTime end) {
		return this.Find(o => o.OrderTime >= begin && o.OrderTime < end);
	}

	// Search any order in [begin, end)
	public List<Order> FindByRange(double begin, double end) {
		return this.Find(o => o.TotalPrice() >= begin && o.TotalPrice() < end);
	}


	// Find by ID
	public Order? FindOrder(long id) {
		var ret = this.Orders.Where(o => o.OrderId == id).ToList();
		return ret.Count == 0 ? null : ret[0];
	}

	public bool HasOrder(long id) => this.FindOrder(id) != null;

	public bool HasOrder(Order? order) => order != null && this.Orders.Contains(order);

	public bool ModifyOrder(long id, Order newOrder) {
		int idx = this.Orders.FindIndex(o => o.OrderId == id);
		if (idx < 0)
			return false;
		newOrder.OrderId = id;
		this.Orders[idx] = newOrder;
		return true;
	}

	public bool ModifyOrder(Order oldOrder, Order newOrder) {
		int idx = this.Orders.FindIndex(o => o.EqualsIgnoreId(oldOrder));
		if (idx < 0)
			return false;
		this.Orders[idx] = newOrder;
		return true;
	}

	public bool DeleteOrder(long id) {
		int idx = this.Orders.FindIndex(o => o.OrderId == id);
		if (idx < 0)
			return false;
		this.Orders.RemoveAt(idx);
		return true;
	}

	public bool DeleteOrder(Order order) {
		int idx = this.Orders.FindIndex(o => o.EqualsIgnoreId(order));
		if (idx < 0)
			return false;
		this.Orders.RemoveAt(idx);
		return true;
	}

	public int Action(Func<Order, bool> match, Action<Order> action) {
		var cnt = 0;
		foreach (Order order in this.Orders.Where(match)) {
			action(order);
			cnt++;
		}

		return cnt;
	}

	public int Action(Customer c, Action<Order> action) {
		return this.Action(o => c.Equals(o.Customer), action);
	}

	public int Action(Goods g, Action<Order> action) {
		return this.Action(o => o.HasGoods(g), action);
	}

	public IEnumerator<Order> GetEnumerator() => this.Orders.GetEnumerator();

	protected bool Equals(OrderService other) => this.Orders.All(other.Orders.Contains) && other.Orders.Count == this.Orders.Count;

	public override bool Equals(object? obj) {
		if (ReferenceEquals(null, obj)) return false;
		if (ReferenceEquals(this, obj)) return true;
		if (obj.GetType() != this.GetType()) return false;
		return this.Equals((OrderService) obj);
	}

	public override int GetHashCode() => this.Orders.GetHashCode();

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
