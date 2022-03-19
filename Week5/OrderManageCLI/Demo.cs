using System.Text;

namespace OrderManageCLI;

public class Demo {
	private const string ModifyFailMsg = "Order modification failed.";
	private const string ModifyCancelMsg = "Order modification cancelled.";
	
	private const string OrderNotFoundMsg = "Order not found.";
	
	private const string DeleteFailMsg = "Order deletion failed.";
	private const string DeleteCancelMsg = "Order deletion cancelled.";
	
	public static void Main() {
		var orderService = new OrderService();
		while (true) {
			// Main menu
			Console.Clear();
			Console.WriteLine("Welcome to OrderManage CLI!");
			Console.WriteLine($"Your current order count is {orderService.Orders.Count}");

			int choice = ConsoleReader.ChoiceReader(
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
				default:
					break;
			}
		}
	}
	
	// Always successes
	private static void CreateOrder(ref OrderService orderService) {
		Console.Clear();
		Console.WriteLine("Creating an order, please enter the order information below:");
		Order? order = ConsoleReader.ReadOrder();
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
		int choice = ConsoleReader.ChoiceReader(
			"Modify by Order ID",
			"Modify by Exact Order Information"
		);

		bool OK = false;
		switch (choice) {
			case 1:
				OK = ModifyOrderByOrderId(ref orderService);
				break;
			case 2:
				OK = ModifyOrderByExactOrderInformation(ref orderService);
				break;
		}

		Console.WriteLine(OK ? "Order modified! Press any key to continue." : "Order modification cancelled / failed. Press any key to continue.");
		Console.ReadKey();
	}

	private static bool ModifyOrderByOrderId(ref OrderService orderService) {
		// Read Order ID from console
		Console.Write("Please enter the Order ID you want to modify, empty to cancel > ");
		string? orderIdStr = Console.ReadLine();
		
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
		Order? orderNew = ConsoleReader.ReadOrder();
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
		Order? orderOld = ConsoleReader.ReadOrder();
		if (orderOld == null) {
			Console.WriteLine(ModifyCancelMsg);
			return false;
		}
		
		Console.WriteLine("Please enter the new Order information below:");
		Order? orderNew = ConsoleReader.ReadOrder();
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
		int choice = ConsoleReader.ChoiceReader(
			"Delete by Order ID",
			"Delete by Exact Order Information"
		);

		bool OK = false;
		switch (choice) {
			case 1:
				OK = DeleteOrderByOrderId(ref orderService);
				break;
			case 2:
				OK = DeleteOrderByExactOrderInformation(ref orderService);
				break;
		}

		Console.WriteLine(OK ? "Order deleted! Press any key to continue." : "Order deletion cancelled / failed. Press any key to continue.");
		Console.ReadKey();
		return OK;
	}
	
	private static bool DeleteOrderByOrderId(ref OrderService orderService) {
		// Read Order ID from console
		Console.Write("Please enter the Order ID you want to delete, empty to cancel > ");
		string? orderIdStr = Console.ReadLine();
		
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
		Order? orderOld = ConsoleReader.ReadOrder();
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

		foreach (var i in orderService) {
			Console.WriteLine(i.ToString());
		}
		
		Console.WriteLine("Press any key to continue.");
		Console.ReadKey();
	}
	
}
