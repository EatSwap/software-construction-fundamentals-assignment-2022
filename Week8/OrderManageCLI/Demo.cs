namespace OrderManageCLI;

public class Demo {
	// private const string ModifyFailMsg = "Order modification failed.";
	private const string ModifyCancelMsg = "Order modification cancelled.";

	private const string OrderNotFoundMsg = "Order not found.";

	// private const string DeleteFailMsg = "Order deletion failed.";
	private const string DeleteCancelMsg = "Order deletion cancelled.";

	private const string SearchCancelMsg = "Search cancelled.";
	// private const string SearchFailMsg = "Search failed.";
	// private const string SearchEmptyMsg = "No orders found.";

	public static void Main() {
		var orderService = new OrderService();
		while (true) {
			// Main menu
			Console.Clear();
			Console.WriteLine("Welcome to OrderManage CLI!");
			Console.WriteLine($"Your current order count is {orderService.Orders.Count}");

			var choice = ConsoleReader.ChoiceReader(
				"Create an Order",
				"Modify an Order",
				"Delete an Order",
				"View all Orders",
				"Search for Orders",
				"Exit"
			);

			switch (choice) {
				case 1:
					CreateOrder(ref orderService);
					break;
				case 2:
					ModifyOrder(ref orderService);
					break;
				case 3:
					DeleteOrder(ref orderService);
					break;
				case 4:
					PrintAllOrders(ref orderService);
					break;
				case 5:
					SearchOrders(ref orderService);
					break;
				case 6:
					return;
			}
		}
	}

	// Always successes
	private static void CreateOrder(ref OrderService orderService) {
		Console.Clear();
		Console.WriteLine("Creating an order, please enter the order information below:");
		var order = ConsoleReader.ReadOrder();
		if (order == null) {
			Console.WriteLine("Order creation cancelled.");
			return;
		}

		orderService.AddOrder(order);
		Console.WriteLine("Order created! Press any key to continue.");
		Console.ReadKey();
	}

	private static void ModifyOrder(ref OrderService orderService) {
		Console.Clear();
		Console.WriteLine("Modifying an order, choose one of the options below:");
		var choice = ConsoleReader.ChoiceReader(
			"Modify by Order ID",
			"Modify by Exact Order Information"
		);

		var OK = false;
		switch (choice) {
			case 1:
				OK = ModifyOrderByOrderId(ref orderService);
				break;
			case 2:
				OK = ModifyOrderByExactOrderInformation(ref orderService);
				break;
			default:
				return;
		}

		Console.WriteLine(OK ? "Order modified! Press any key to continue." : "Order modification cancelled / failed. Press any key to continue.");
		Console.ReadKey();
	}

	private static bool ModifyOrderByOrderId(ref OrderService orderService) {
		// Read Order ID from console
		Console.Write("Please enter the Order ID you want to modify, empty to cancel > ");
		var orderIdStr = Console.ReadLine();

		if (string.IsNullOrWhiteSpace(orderIdStr)) {
			Console.WriteLine(ModifyCancelMsg);
			return false;
		}

		int orderId;
		while (!int.TryParse(orderIdStr, out orderId)) {
			Console.WriteLine("Invalid Order ID, please try again.");
			Console.Write("Please enter the Order ID you want to modify, empty to cancel > ");
			orderIdStr = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(orderIdStr)) {
				Console.WriteLine(ModifyCancelMsg);
				return false;
			}
		}

		// Find the order
		if (!orderService.HasOrder(orderId)) {
			Console.WriteLine(OrderNotFoundMsg);
			return false;
		}

		// Read Order information from console
		Console.WriteLine("Please enter the new Order information below:");
		var orderNew = ConsoleReader.ReadOrder();
		if (orderNew == null) {
			Console.WriteLine(ModifyCancelMsg);
			return false;
		}

		// Modify Order
		return orderService.ModifyOrder(orderId, orderNew);
	}

	private static bool ModifyOrderByExactOrderInformation(ref OrderService orderService) {
		// Read Order information from console
		Console.WriteLine("Please enter the old Order information below:");
		var orderOld = ConsoleReader.ReadOrder();
		if (orderOld == null) {
			Console.WriteLine(ModifyCancelMsg);
			return false;
		}

		Console.WriteLine("Please enter the new Order information below:");
		var orderNew = ConsoleReader.ReadOrder();
		if (orderNew == null) {
			Console.WriteLine(ModifyCancelMsg);
			return false;
		}

		// Modify Order
		var ret = orderService.ModifyOrder(orderOld, orderNew);

		if (!ret)
			Console.WriteLine(OrderNotFoundMsg);

		return ret;
	}

	private static bool DeleteOrder(ref OrderService orderService) {
		Console.Clear();
		Console.WriteLine("Deleting an order, choose one of the options below:");
		var choice = ConsoleReader.ChoiceReader(
			"Delete by Order ID",
			"Delete by Exact Order Information"
		);

		var OK = false;
		switch (choice) {
			case 1:
				OK = DeleteOrderByOrderId(ref orderService);
				break;
			case 2:
				OK = DeleteOrderByExactOrderInformation(ref orderService);
				break;
			default:
				return false;
		}

		Console.WriteLine(OK ? "Order deleted! Press any key to continue." : "Order deletion cancelled / failed. Press any key to continue.");
		Console.ReadKey();
		return OK;
	}

	private static bool DeleteOrderByOrderId(ref OrderService orderService) {
		// Read Order ID from console
		Console.Write("Please enter the Order ID you want to delete, empty to cancel > ");
		var orderIdStr = Console.ReadLine();

		if (string.IsNullOrWhiteSpace(orderIdStr)) {
			Console.WriteLine(DeleteCancelMsg);
			return false;
		}

		int orderId;
		while (!int.TryParse(orderIdStr, out orderId)) {
			Console.WriteLine("Invalid Order ID, please try again.");
			Console.Write("Please enter the Order ID you want to delete, empty to cancel > ");
			orderIdStr = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(orderIdStr)) {
				Console.WriteLine(DeleteCancelMsg);
				return false;
			}
		}

		// Find the order
		if (!orderService.HasOrder(orderId)) {
			Console.WriteLine(OrderNotFoundMsg);
			return false;
		}

		// Delete Order
		return orderService.DeleteOrder(orderId);
	}

	private static bool DeleteOrderByExactOrderInformation(ref OrderService orderService) {
		// Read Order information from console
		Console.WriteLine("Please enter the old Order information below:");
		var orderOld = ConsoleReader.ReadOrder();
		if (orderOld == null) {
			Console.WriteLine(DeleteCancelMsg);
			return false;
		}

		// Delete Order
		var ret = orderService.DeleteOrder(orderOld);

		if (!ret)
			Console.WriteLine(OrderNotFoundMsg);

		return ret;
	}

	private static void PrintAllOrders(ref OrderService orderService) {
		Console.Clear();
		Console.WriteLine("Printing all orders:");

		foreach (var i in orderService) Console.WriteLine(i.ToString());

		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}

	private static void SearchOrders(ref OrderService orderService) {
		Console.Clear();
		Console.WriteLine("Searching orders, choose one of the options below:");
		var choice = ConsoleReader.ChoiceReader(
			"Search by Order ID",
			"Search by Exact Order Information",
			"Search by Customer",
			"Search by Product",
			"Search by Order Date",
			"Search by Order Date Range",
			"Search by Order Amount Range"
		);

		switch (choice) {
			case 1:
				SearchOrdersByOrderId(ref orderService);
				break;
			case 2:
				SearchOrdersByExactOrderInformation(ref orderService);
				break;
			case 3:
				SearchOrdersByCustomer(ref orderService);
				break;
			case 4:
				SearchOrdersByProduct(ref orderService);
				break;
			case 5:
				SearchOrdersByOrderDate(ref orderService);
				break;
			case 6:
				SearchOrdersByOrderDateRange(ref orderService);
				break;
			case 7:
				SearchOrdersByOrderAmountRange(ref orderService);
				break;
			default:
				return;
		}
	}

	private static void SearchOrdersByOrderId(ref OrderService orderService) {
		// Read Order ID from console
		Console.Write("Please enter the Order ID you want to search, empty to cancel > ");
		var orderIdStr = Console.ReadLine();

		if (string.IsNullOrWhiteSpace(orderIdStr)) {
			Console.WriteLine(SearchCancelMsg);
			return;
		}

		int orderId;
		while (!int.TryParse(orderIdStr, out orderId)) {
			Console.WriteLine("Invalid Order ID, please try again.");
			Console.Write("Please enter the Order ID you want to search, empty to cancel > ");
			orderIdStr = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(orderIdStr)) {
				Console.WriteLine(SearchCancelMsg);
				return;
			}
		}

		// Find the order
		var ret = orderService.Find(o => o.OrderId == orderId);

		// Print the order
		Console.WriteLine(ret.Count == 0 ? OrderNotFoundMsg : ret[0].ToString());

		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}

	private static void SearchOrdersByExactOrderInformation(ref OrderService orderService) {
		// Read Order information from console
		Console.WriteLine("Please enter the old Order information below:");
		var orderOld = ConsoleReader.ReadOrder();
		if (orderOld == null) {
			Console.WriteLine(SearchCancelMsg);
			return;
		}

		// Find the order
		var ret = orderService.Find(o => o.EqualsIgnoreId(orderOld));

		// Print the order
		Console.WriteLine(ret.Count == 0 ? OrderNotFoundMsg : ret[0].ToString());

		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}

	private static void SearchOrdersByCustomer(ref OrderService orderService) {
		// Read Customer name from console
		Console.WriteLine("Please enter the Customer you want to search below:");

		var c = ConsoleReader.ReadCustomer();

		// Find the order
		var ret = orderService.Find(c);

		// Print the order
		if (ret.Count == 0) {
			Console.WriteLine(OrderNotFoundMsg);
		} else {
			ConsoleReader.ReadOrderByAndSort(ref ret);
			foreach (var i in ret)
				Console.WriteLine(i.ToString());
		}

		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}

	private static void SearchOrdersByProduct(ref OrderService orderService) {
		// Read Product name from console
		Console.WriteLine("Please enter the Product you want to search below:");

		var p = ConsoleReader.ReadProduct();

		// Find the order
		var ret = orderService.Find(p);

		// Print the order
		if (ret.Count == 0) {
			Console.WriteLine(OrderNotFoundMsg);
		} else {
			ConsoleReader.ReadOrderByAndSort(ref ret);
			foreach (var i in ret)
				Console.WriteLine(i.ToString());
		}

		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}

	private static void SearchOrdersByOrderDate(ref OrderService orderService) {
		// Read Order Date from console
		Console.WriteLine("Please enter the Order Date you want to search below:");

		var d = ConsoleReader.ReadDate("date to search");

		var dStart = d.Date + TimeSpan.Zero;
		var dEnd = d.Date + TimeSpan.FromDays(1);

		// Find the order
		var ret = orderService.FindByRange(dStart, dEnd);

		// Print the order
		if (ret.Count == 0) {
			Console.WriteLine(OrderNotFoundMsg);
		} else {
			ConsoleReader.ReadOrderByAndSort(ref ret);
			foreach (var i in ret)
				Console.WriteLine(i.ToString());
		}

		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}

	private static void SearchOrdersByOrderDateRange(ref OrderService orderService) {
		// Read Order Date Range from console
		Console.WriteLine("Please enter the Order Date Range you want to search below:");

		var dStart = ConsoleReader.ReadDate("start date & time to search");
		var dEnd = ConsoleReader.ReadDate("end date & time to search");

		// Find the order
		var ret = orderService.FindByRange(dStart, dEnd);

		// Print the order
		if (ret.Count == 0) {
			Console.WriteLine(OrderNotFoundMsg);
		} else {
			ConsoleReader.ReadOrderByAndSort(ref ret);
			foreach (var i in ret)
				Console.WriteLine(i.ToString());
		}

		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}

	private static void SearchOrdersByOrderAmountRange(ref OrderService orderService) {
		// Read Order Amount Range from console
		Console.WriteLine("Please enter the Order Amount Range you want to search below:");

		var amountStart = ConsoleReader.ReadDouble("start amount to search (inclusive)");
		var amountEnd = ConsoleReader.ReadDouble("end amount to search (exclusive)");

		// Find the order
		var ret = orderService.FindByRange(amountStart, amountEnd);

		// Print the order
		if (ret.Count == 0) {
			Console.WriteLine(OrderNotFoundMsg);
		} else {
			ConsoleReader.ReadOrderByAndSort(ref ret);
			foreach (var i in ret)
				Console.WriteLine(i.ToString());
		}

		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}
}