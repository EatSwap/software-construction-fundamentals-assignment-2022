using System.Text;

namespace OrderManageCLI;

public class Demo {
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

		switch (choice) {
			case 1:
				break;
		}
		
		Order? order = ConsoleReader.ReadOrder();
		if (order == null) {
			Console.WriteLine("Order modification cancelled.");
			return;
		} 
		// orderService.ModifyOrder(order);
		Console.WriteLine("Order modified! Press any key to continue.");
		Console.ReadKey();
	}
	
}
