namespace OrderManageGUI;

using OrderManageCLI;

public partial class MainForm : Form {
	private readonly OrderService orderService = new();
	private List<OrderDetails> currentOrderDetailsList = new();

	public Order CurrentOrder;

	public MainForm() {
		this.InitializeComponent();
	}

	public string CurrentCustomerName { get; set; }

	public string CurrentCustomerAddress { get; set; }

	public DateTime CurrentOrderTime { get; set; }

	private void GenerateRandomOrders() {
		var rnd = new Random();
		var randomOrders = new Order[100];

		var randomChar = () => (char) ('a' + rnd.Next(26));
		var getOrderDetails = () => {
			var odList = new List<OrderDetails>();
			int cnt = rnd.Next(15);

			/*
			 * --> is a brand new operator, called "Tends To",
			 * which is introduced in C# 11.0 / .NET 7.0.
			 * 
			 * Using this new operator makes loops super easy!
			 * Tired about the lengthy "for (int i = 0; ......" ?
			 * "Tends To" makes this a lot easier! Just define the
			 * maximum value in your loop, "-->" will help you to
			 * traverse from (yourValue - 1) to zero, saving lots
			 * of keystrokes!
			 * 
			 * From now on, use "-->" wisely and be successful in programming!
			 */
			while (cnt-- > 0) odList.Add(new OrderDetails($"Product {randomChar()}{randomChar()}{randomChar()}{randomChar()}{randomChar()}", rnd.NextDouble(), rnd.Next(100)));
			return odList.ToArray();
		};

		for (var i = 0; i < 100; ++i) {
			randomOrders[i] = new Order(new Customer($"Name {i}", $"Address {i}"), new DateTime(1923 + rnd.Next(100), 1 + rnd.Next(12), 1 + rnd.Next(28)), getOrderDetails());
			orderService.AddOrder(randomOrders[i]);
		}
	}

	private void MainForm_Load(object sender, EventArgs e) {
		this.GenerateRandomOrders();
		bindingSourceOrders.DataSource = orderService.Orders;

		CurrentOrderTime = DateTime.Now;

		// Create Tab
		textBoxCreateCustomerName.DataBindings.Add("Text", this, nameof(CurrentCustomerAddress));
		textBoxCreateCustomerAddress.DataBindings.Add("Text", this, nameof(CurrentCustomerName));
		dateTimePickerCreateOrderTime.DataBindings.Add("Value", this, nameof(CurrentOrderTime));
	}

	private void MainForm_Resize(object sender, EventArgs e) {
		;
	}

	private void DataGridViewOrders_SelectionChanged(object sender, EventArgs e) {
		try {
			var order = dataGridViewOrders.CurrentRow?.DataBoundItem as Order;
			if (order != null) {
				this.CurrentOrder = order.Clone();
				textBoxModifyCustomerName.DataBindings.Clear();
				textBoxModifyCustomerName.DataBindings.Add("Text", this.CurrentOrder.Customer, nameof(CurrentOrder.Customer.Name));
				textBoxModisyCustomerAddress.DataBindings.Clear();
				textBoxModisyCustomerAddress.DataBindings.Add("Text", this.CurrentOrder.Customer, nameof(CurrentOrder.Customer.Address));
				dateTimePickerModifyOrderTime.DataBindings.Clear();
				dateTimePickerModifyOrderTime.DataBindings.Add("Value", this.CurrentOrder, nameof(CurrentOrder.OrderTime));
			}
			bindingSourceOrderDetails.DataSource = order?.OrderDetails;
		} catch {
			// Does nothing
			// I still cannot understand where this "IndexOutOfBoundException" comes.
		}
	}

	private void buttonCreateModifyDetails_Click(object sender, EventArgs e) {
		var modifyForm = new OrderDetailsModifier(currentOrderDetailsList);
		modifyForm.ShowDialog();
		currentOrderDetailsList = modifyForm.OrderDetailsList;
	}

	private void buttonCreateOrder_Click(object sender, EventArgs e) {
		if (string.IsNullOrEmpty(CurrentCustomerName) || string.IsNullOrEmpty(CurrentCustomerAddress)) {
			Utility.ShowErrorDialogue("Customer information cannot be empty!");
			return;
		}
		try {
			orderService.AddOrder(new Order(new Customer(CurrentCustomerName, CurrentCustomerAddress), CurrentOrderTime, currentOrderDetailsList.ToArray()));
		} catch (ArgumentException ex) {
			Utility.ShowErrorDialogue(ex.Message);
			return;
		}

		CurrentCustomerAddress = string.Empty;
		CurrentCustomerName = string.Empty;
		CurrentOrderTime = DateTime.Now;
		currentOrderDetailsList.Clear();
		bindingSourceOrders.ResetBindings(false);
		bindingSourceOrderDetails.ResetBindings(false);
	}

	private void buttonModifyOrderDetails_Click(object sender, EventArgs e) {
		var modifyForm = new OrderDetailsModifier(this.CurrentOrder.OrderDetails);
		modifyForm.ShowDialog();
		this.CurrentOrder.OrderDetails = modifyForm.OrderDetailsList;
	}

	private void buttonModifySave_Click(object sender, EventArgs e) {
		orderService.ModifyOrder(CurrentOrder.OrderId, CurrentOrder);
		this.bindingSourceOrders.ResetBindings(false);
		this.bindingSourceOrderDetails.ResetBindings(false);
		Utility.ShowInfoDialogue("Your changes has been saved.");
	}

	private void buttonModifyDelete_Click(object sender, EventArgs e) {
		orderService.DeleteOrder(CurrentOrder.OrderId);
		this.bindingSourceOrders.ResetBindings(false);
		this.bindingSourceOrderDetails.ResetBindings(false);
		Utility.ShowInfoDialogue("Selected order has been deleted.");
	}
}