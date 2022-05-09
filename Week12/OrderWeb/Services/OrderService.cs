namespace OrderWeb.Services;

using OrderManageCLI.models;

public sealed class OrderService {
	// Equivalent Java code:
	// @Autowired
	// private OrderService orderService;

	private static readonly OrderManageCLI.OrderService orderService = new();
	
	public void createOrder(Order order) {
		orderService.AddOrder(order);
	}
	
	public void updateOrder(Order order) {
		orderService.ModifyOrder(order.OrderId, order);
	}
	
	public void updateOrder(long orderId, Order order) {
		orderService.ModifyOrder(orderId, order);
	}
	
	public void deleteOrder(int orderId) {
		orderService.DeleteOrder(orderId);
	}
	
	public Order? getOrder(int orderId) {
		return orderService.FindOrder(orderId);
	}

	public List<Order> getAllOrders() {
		return orderService.Find(order => true);
	}
	
}
