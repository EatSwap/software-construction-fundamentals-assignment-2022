namespace OrderManageCLI;

public class ConsoleReader {
	public static OrderDetails? ReadOrderDetails(string prompt = "") {
		Console.Write($"OrderDetails: Enter your goods name, empty to terminate [{prompt}] > ");
		string? goodsName = Console.ReadLine();
		if (string.IsNullOrWhiteSpace(goodsName))
			return null;

		Console.Write($"OrderDetails: Enter your goods price [{prompt}] > ");
		double goodsPrice;
		while (!double.TryParse(Console.ReadLine(), out goodsPrice) || goodsPrice < 0.0) {
			Console.WriteLine("You must enter a valid price!");
			Console.Write($"OrderDetails: Enter your goods price [{prompt}] > ");
		}

		Console.Write($"OrderDetails: Enter your goods quantity [{prompt}] > ");
		int goodsQuantity;
		while (!int.TryParse(Console.ReadLine(), out goodsQuantity) || goodsQuantity < 0) {
			Console.WriteLine("You must enter a valid quantity!");
			Console.Write($"OrderDetails: Enter your goods quantity [{prompt}] > ");
		}

		return new OrderDetails(goodsName, goodsPrice, goodsQuantity);
	}

	public static Order? ReadOrder() {
		Console.Write("Order: Enter your customer name, empty to terminate > ");
		string? customerName = Console.ReadLine();
		if (string.IsNullOrWhiteSpace(customerName))
			return null;

		Console.Write("Order: Enter your customer address > ");
		string? customerAddress = Console.ReadLine();
		while (string.IsNullOrWhiteSpace(customerAddress)) {
			Console.WriteLine("You must enter a valid address!");
			Console.Write("Order: Enter your customer address > ");
		}

		Console.Write("Order: Enter your order time, empty for now > ");
		string? orderTimeStr = Console.ReadLine();
		DateTime orderTime;
		while (!DateTime.TryParse(orderTimeStr, out orderTime)) {
			if (string.IsNullOrWhiteSpace(orderTimeStr)) {
				orderTime = DateTime.Now;
				break;
			}

			Console.WriteLine("You must enter a valid time!");
			Console.Write("Order: Enter your order time > ");
		}

		var orderDetailsList = new List<OrderDetails>();
		while (true) {
			OrderDetails? orderDetails = ReadOrderDetails($"{orderDetailsList.Count + 1}");
			if (orderDetails == null)
				break;
			orderDetailsList.Add(orderDetails);
		}

		return new Order(new Customer(customerName, customerAddress), orderTime, orderDetailsList.ToArray());
	}

	public static int ChoiceReader(params string[] choices) {
		Console.WriteLine("Please choose one of the following:");
		for (var i = 0; i < choices.Length; i++)
			Console.WriteLine($"{i + 1}. {choices[i]}");
		Console.Write("Your choice > ");
		int choice;
		while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > choices.Length) {
			Console.WriteLine("You must enter a valid choice!");
			Console.Write("Your choice > ");
		}

		return choice;
	}

	public static Customer ReadCustomer() {
		Console.Write("Customer: Enter the customer's name > ");
		string? name = Console.ReadLine();
		while (string.IsNullOrWhiteSpace(name)) {
			Console.WriteLine("You must enter a valid name!");
			Console.Write("Customer: Enter your name > ");
		}

		Console.Write("Customer: Enter the customer's address > ");
		string? address = Console.ReadLine();
		while (string.IsNullOrWhiteSpace(address)) {
			Console.WriteLine("You must enter a valid address!");
			Console.Write("Customer: Enter your address > ");
		}

		return new Customer(name, address);
	}

	public static Goods ReadProduct() {
		Console.Write("Product: Enter the product's name > ");
		string? name = Console.ReadLine();
		while (string.IsNullOrWhiteSpace(name)) {
			Console.WriteLine("You must enter a valid name!");
			Console.Write("Product: Enter your name > ");
		}

		Console.Write("Product: Enter the product's price > ");
		double price;
		while (!double.TryParse(Console.ReadLine(), out price) || price < 0.0) {
			Console.WriteLine("You must enter a valid price!");
			Console.Write("Product: Enter your price > ");
		}

		return new Goods(name, price);
	}

	public static DateTime ReadDate(string name) {
		Console.Write($"Date: Enter the {name}, empty for now > ");
		string? dateStr = Console.ReadLine();
		DateTime date;
		while (!DateTime.TryParse(dateStr, out date)) {
			if (string.IsNullOrWhiteSpace(dateStr)) {
				date = DateTime.Now;
				break;
			}

			Console.WriteLine("You must enter a valid date!");
			Console.Write($"Date: Enter the {name}, empty for now > ");
		}

		return date;
	}

	public static double ReadDouble(string name) {
		Console.Write($"{name}: Enter the {name}, empty for 0.0 > ");
		string? priceStr = Console.ReadLine();
		double price;
		while (!double.TryParse(priceStr, out price) || price < 0.0) {
			if (string.IsNullOrWhiteSpace(priceStr)) {
				price = 0.0;
				break;
			}

			Console.WriteLine("You must enter a valid price!");
			Console.Write($"{name}: Enter the {name}, empty for 0.0 > ");
		}

		return price;
	}

	public static void ReadOrderByAndSort(ref List<Order> orders) {
		Console.WriteLine("Here you can choose your favourite ordering option:");

		int choice = ChoiceReader(
			"By customer name [ASCENDING]",
			"By customer name [DESCENDING]",
			"By customer address [ASCENDING]",
			"By customer address [DESCENDING]",
			"By order time [ASCENDING]",
			"By order time [DESCENDING]",
			"By order amount [ASCENDING]",
			"By order amount [DESCENDING]",
			"By Order ID [ASCENDING]",
			"By Order ID [DESCENDING]"
		);

		switch (choice) {
			case 1:
			case 2:
				orders.Sort((a, b) => (choice % 2 == 0 ? -1 : 1) * a.Customer.Name.CompareTo(b.Customer.Name));
				break;
			case 3:
			case 4:
				orders.Sort((a, b) => (choice % 2 == 0 ? -1 : 1) * a.Customer.Address.CompareTo(b.Customer.Address));
				break;
			case 5:
			case 6:
				orders.Sort((a, b) => (choice % 2 == 0 ? -1 : 1) * a.OrderTime.CompareTo(b.OrderTime));
				break;
			case 7:
			case 8:
				orders.Sort((a, b) => (choice % 2 == 0 ? -1 : 1) * a.TotalPrice().CompareTo(b.TotalPrice()));
				break;
			case 9:
			case 10:
				orders.Sort((a, b) => (choice % 2 == 0 ? -1 : 1) * a.OrderId.CompareTo(b.OrderId));
				break;
		}
	}
}
