namespace OrderManageCLI;

using System.Linq.Dynamic.Core;
using System.Xml.Serialization;
using database;
using models;

[Serializable]
public class OrderService {
	public List<Order> Orders {
		get {
			using var db = new OrderContext();
			return db.Orders.ToList();
		}
	}

	public void AddOrder(Order order) {
		using var db = new OrderContext();
		db.Add(order);
		db.SaveChanges();
	}
	
	public void AddOrders(List<Order> orders) {
		using var db = new OrderContext();
		db.AddRange(orders);
		db.SaveChanges();
	}


	public void RemoveOrder(Order? order) {
		if (order == null)
			throw new ArgumentException("OrderService: Order is null");
		using var db = new OrderContext();
		db.Remove(order);
		db.SaveChanges();
	}

	public void RemoveOrder(long orderId) {
		using var db = new OrderContext();
		var result = db.Find(typeof(Order), orderId);
		if (result == null)
			throw new ArgumentException("OrderService: Order not found");
		this.RemoveOrder(result as Order);
		// db.SaveChanges();
	}

	public List<Order> Find(Func<Order, bool> match, string orderBy = "TotalPrice() DESC") {
		using var db = new OrderContext();
		return db.Orders.Where(match).AsQueryable().OrderBy(orderBy).ToList();
	}

	public List<Order> Find(Func<Order, bool> match, Comparison<Order> sortFunc) {
		using var db = new OrderContext();
		var ret = db.Orders.Where(match).ToList();
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
		using var db = new OrderContext();
		var ret = db.Orders.Where(o => o.OrderId == id).ToList();
		return ret.Count == 0 ? null : ret[0];
	}

	public bool HasOrder(long id) => this.FindOrder(id) != null;

	public bool HasOrder(Order? order) {
		using var db = new OrderContext();
		if (order == null)
			throw new ArgumentException("OrderService: Order is null");
		return db.Orders.Contains(order);
	}

	public bool ModifyOrder(long id, Order newOrder) {
		using var db = new OrderContext();
		Order? order = this.FindOrder(id);
		if (order == null)
			throw new ArgumentException("OrderService: Order not found");
		newOrder.OrderId = id;
		db.Update(newOrder);
		db.SaveChanges();
		return true;
	}

	public bool ModifyOrder(Order oldOrder, Order newOrder) {
		using var db = new OrderContext();
		Order? order = this.FindOrder(oldOrder.OrderId);
		if (order == null)
			throw new ArgumentException("OrderService: Order not found");
		newOrder.OrderId = oldOrder.OrderId;
		db.Update(newOrder);
		db.SaveChanges();
		return true;
	}

	public bool DeleteOrder(long id) {
		Order? order = this.FindOrder(id);
		if (order == null)
			throw new ArgumentException("OrderService: Order not found");
		this.DeleteOrder(order);
		return true;
	}

	public bool DeleteOrder(Order order) {
		using var db = new OrderContext();
		db.Remove(order);
		db.SaveChanges();
		return true;
	}

	public int Action(Func<Order, bool> match, Action<Order> action) {
		using var db = new OrderContext();
		var cnt = 0;
		foreach (Order order in db.Orders.Where(match)) {
			action(order);
			db.Update(order);
			cnt++;
		}
		db.SaveChanges();
		return cnt;
	}

	public int Action(Customer c, Action<Order> action) {
		return this.Action(o => c.Equals(o.Customer), action);
	}

	public int Action(Goods g, Action<Order> action) {
		return this.Action(o => o.HasGoods(g), action);
	}

	public IEnumerator<Order> GetEnumerator() {
		using var db = new OrderContext();
		return db.Orders.ToList().GetEnumerator();
	}

	protected bool Equals(OrderService other) => this.Orders.All(other.Orders.Contains) && other.Orders.Count == this.Orders.Count;

	public override bool Equals(object? obj) {
		if (ReferenceEquals(null, obj)) return false;
		if (ReferenceEquals(this, obj)) return true;
		if (obj.GetType() != this.GetType()) return false;
		return this.Equals((OrderService) obj);
	}

	public override int GetHashCode() => this.Orders.GetHashCode();

	public bool Export(string fileName) {
		using var db = new OrderContext();
		try {
			var formatter = new XmlSerializer(typeof(List<Order>));
			using var stream = new FileStream(fileName, FileMode.Create);
			formatter.Serialize(stream, db.Orders.ToList());
			return true;
		} catch {
			return false;
		}
	}

	public static OrderService? Import(string fileName) {
		try {
			var formatter = new XmlSerializer(typeof(List<Order>));
			using var stream = new FileStream(fileName, FileMode.Open);
			var orderList = formatter.Deserialize(stream) as List<Order>;
			if (orderList == null)
				return null;
			var ret = new OrderService();
			ret.AddOrders(orderList);
			return ret;
		} catch {
			return null;
		}
	}
}
