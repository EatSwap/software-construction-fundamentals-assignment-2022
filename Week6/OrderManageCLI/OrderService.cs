﻿using System.Linq.Dynamic.Core;

namespace OrderManageCLI;

public class OrderService {
	public List<Order> Orders { get; } = new();

	public void AddOrder(Order order) {
		if (Orders.Contains(order))
			throw new Exception("OrderService: Order already exists");
		if (Orders.FindIndex(o => o.OrderId == order.OrderId) != -1)
			throw new Exception("OrderService: Duplicated OrderId");
		Orders.Add(order);
	}

	public void RemoveOrder(Order order) {
		if (!Orders.Contains(order))
			throw new Exception("OrderService: Order not found");
		Orders.Remove(order);
	}

	public void RemoveOrder(int index) {
		if (index < 0 || index >= Orders.Count)
			throw new IndexOutOfRangeException($"Index {index} is out of range: [0, {Orders.Count})");
		Orders.RemoveAt(index);
	}

	public void RemoveAllOrders() {
		Orders.Clear();
	}

	public void SortOrders(IComparer<Order> comparer) {
		Orders.Sort(comparer);
	}

	public List<Order> Find(Func<Order, bool> match, string orderBy = "TotalPrice DESC") {
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
	public Order? FindOrder(int id) {
		var ret = Orders.Where(o => o.OrderId == id).ToList();
		return ret.Count == 0 ? null : ret[0];
	}

	public bool HasOrder(int id) {
		return FindOrder(id) != null;
	}

	public bool ModifyOrder(int id, Order newOrder) {
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

	public bool DeleteOrder(int id) {
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
}