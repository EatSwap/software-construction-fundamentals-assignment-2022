namespace OrderWeb.Services;

public sealed class OrderService {
	// Equivalent Java code:
	// @Autowired
	// private OrderService orderService;

	private static readonly OrderManageCLI.OrderService orderService = new();
}