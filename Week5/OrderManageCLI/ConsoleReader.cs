namespace OrderManageCLI; 

public class ConsoleReader {
	public static OrderDetails? ReadOrderDetails(string prompt = "") {
		Console.Write($"OrderDetails: Enter your goods name, empty to terminate [{prompt}] > ");
		string? goodsName = Console.ReadLine();
		if (String.IsNullOrWhiteSpace(goodsName))
			return null;

		Console.Write($"OrderDetails: Enter your goods price [{prompt}] > ");
		double goodsPrice;
		while (!Double.TryParse(Console.ReadLine(), out goodsPrice) || goodsPrice < 0.0) {
			Console.WriteLine("You must enter a valid price!");
			Console.Write($"OrderDetails: Enter your goods price [{prompt}] > ");
		}

		Console.Write($"OrderDetails: Enter your goods quantity [{prompt}] > ");
		int goodsQuantity;
		while (!Int32.TryParse(Console.ReadLine(), out goodsQuantity) || goodsQuantity < 0) {
			Console.WriteLine("You must enter a valid quantity!");
			Console.Write($"OrderDetails: Enter your goods quantity [{prompt}] > ");
		}

		return new OrderDetails(goodsName, goodsPrice, goodsQuantity);
	}

	public static Order? ReadOrder() {
		Console.Write($"Order: Enter your customer name, empty to terminate > ");
		string? customerName = Console.ReadLine();
		if (String.IsNullOrWhiteSpace(customerName))
			return null;

		Console.Write($"Order: Enter your customer address > ");
		string? customerAddress = Console.ReadLine();
		while (string.IsNullOrWhiteSpace(customerAddress)) {
			Console.WriteLine("You must enter a valid address!");
			Console.Write($"Order: Enter your customer address > ");
		}
		
		Console.Write($"Order: Enter your order time, empty for now > ");
		string? orderTimeStr = Console.ReadLine();
		DateTime orderTime;
		while (!DateTime.TryParse(orderTimeStr, out orderTime)) {
			if (string.IsNullOrWhiteSpace(orderTimeStr)) {
				orderTime = DateTime.Now;
				break;
			}
			Console.WriteLine("You must enter a valid time!");
			Console.Write($"Order: Enter your order time > ");
		}

		var orderDetailsList = new List<OrderDetails>();
		while (true) {
			var orderDetails = ReadOrderDetails($"{orderDetailsList.Count + 1}");
			if (orderDetails == null)
				break;
			orderDetailsList.Add(orderDetails);
		}

		return new Order(new Customer(customerName, customerAddress), orderTime, orderDetailsList.ToArray());
	}

	public static int ChoiceReader(params string[] choices) {
		Console.WriteLine("Please choose one of the following:");
		for (int i = 0; i < choices.Length; i++)
			Console.WriteLine($"{i + 1}. {choices[i]}");
		Console.Write($"Your choice > ");
		int choice;
		while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > choices.Length) {
			Console.WriteLine("You must enter a valid choice!");
			Console.Write($"Your choice > ");
		}
		return choice;
	}
}