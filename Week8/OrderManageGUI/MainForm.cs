namespace OrderManageGUI;

using OrderManageCLI;

public partial class MainForm : Form {
	private readonly OrderService orderService = new();

	public Order CurrentOrder;
	
	private List<OrderDetails> currentOrderDetailsList = new();
	
	private List<Order> queriedOrders = new();

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
			this.orderService.AddOrder(randomOrders[i]);
		}
	}

	private void MainForm_Load(object sender, EventArgs e) {
		this.GenerateRandomOrders();
		this.bindingSourceOrders.DataSource = this.orderService.Orders;

		this.CurrentOrderTime = DateTime.Now;

		// Create Tab
		this.textBoxCreateCustomerName.DataBindings.Add("Text", this, nameof(this.CurrentCustomerAddress));
		this.textBoxCreateCustomerAddress.DataBindings.Add("Text", this, nameof(this.CurrentCustomerName));
		this.dateTimePickerCreateOrderTime.DataBindings.Add("Value", this, nameof(this.CurrentOrderTime));
	}

	private void MainForm_Resize(object sender, EventArgs e) {
		;
	}

	private void DataGridViewOrders_SelectionChanged(object sender, EventArgs e) {
		try {
			var order = this.dataGridViewOrders.CurrentRow?.DataBoundItem as Order;
			if (order != null) {
				this.CurrentOrder = order.Clone();
				this.textBoxModifyCustomerName.DataBindings.Clear();
				this.textBoxModifyCustomerName.DataBindings.Add("Text", this.CurrentOrder.Customer, nameof(this.CurrentOrder.Customer.Name));
				this.textBoxModifyCustomerAddress.DataBindings.Clear();
				this.textBoxModifyCustomerAddress.DataBindings.Add("Text", this.CurrentOrder.Customer, nameof(this.CurrentOrder.Customer.Address));
				this.dateTimePickerModifyOrderTime.DataBindings.Clear();
				this.dateTimePickerModifyOrderTime.DataBindings.Add("Value", this.CurrentOrder, nameof(this.CurrentOrder.OrderTime));
			}
			this.bindingSourceOrderDetails.DataSource = order?.OrderDetails;
		} catch {
			// Does nothing
			// I still cannot understand where this "IndexOutOfBoundException" comes.
		}
	}

	private void buttonCreateModifyDetails_Click(object sender, EventArgs e) {
		var modifyForm = new OrderDetailsModifier(this.currentOrderDetailsList);
		modifyForm.ShowDialog();
		this.currentOrderDetailsList = modifyForm.OrderDetailsList;
	}

	private void buttonCreateOrder_Click(object sender, EventArgs e) {
		if (string.IsNullOrEmpty(this.CurrentCustomerName) || string.IsNullOrEmpty(this.CurrentCustomerAddress)) {
			Utility.ShowErrorDialogue("Customer information cannot be empty!");
			return;
		}
		try {
			this.orderService.AddOrder(new Order(new Customer(this.CurrentCustomerName, this.CurrentCustomerAddress), this.CurrentOrderTime, this.currentOrderDetailsList.ToArray()));
		} catch (ArgumentException ex) {
			Utility.ShowErrorDialogue(ex.Message);
			return;
		}

		this.CurrentCustomerAddress = string.Empty;
		this.CurrentCustomerName = string.Empty;
		this.CurrentOrderTime = DateTime.Now;
		this.currentOrderDetailsList.Clear();
		this.bindingSourceOrders.ResetBindings(false);
		this.bindingSourceOrderDetails.ResetBindings(false);
	}

	private void buttonModifyOrderDetails_Click(object sender, EventArgs e) {
		var modifyForm = new OrderDetailsModifier(this.CurrentOrder.OrderDetails);
		modifyForm.ShowDialog();
		this.CurrentOrder.OrderDetails = modifyForm.OrderDetailsList;
	}

	private void buttonModifySave_Click(object sender, EventArgs e) {
		this.orderService.ModifyOrder(this.CurrentOrder.OrderId, this.CurrentOrder);
		this.bindingSourceOrders.ResetBindings(false);
		this.bindingSourceOrderDetails.ResetBindings(false);
		Utility.ShowInfoDialogue("Your changes has been saved.");
	}

	private void buttonModifyDelete_Click(object sender, EventArgs e) {
		this.orderService.DeleteOrder(this.CurrentOrder.OrderId);
		this.bindingSourceOrders.ResetBindings(false);
		this.bindingSourceOrderDetails.ResetBindings(false);
		Utility.ShowInfoDialogue("Selected order has been deleted.");
	}

	private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "XML document|*.xml";
		saveFileDialog.Title = "Choose Location to Save";
		if (saveFileDialog.ShowDialog() == DialogResult.OK) {
			try {
				this.orderService.Export(saveFileDialog.FileName);
			} catch (Exception ex) {
				Utility.ShowErrorDialogue(ex.Message);
				return;
			}
			Utility.ShowInfoDialogue("Orders exported successfully!");
		} else {
			Utility.ShowErrorDialogue("Saving has been cancelled!");
		}
	}

	private void openToolStripMenuItem_Click(object sender, EventArgs e) {
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "XML document|*.xml";
		openFileDialog.Title = "Choose File to Load";
		if (openFileDialog.ShowDialog() == DialogResult.OK) {
			try {
				var newService = OrderService.Import(openFileDialog.FileName);
				if (newService == null) {
					Utility.ShowErrorDialogue("File is not a valid XML file!");
					return;
				}
				if (MessageBox.Show("Your unsaved orders will be lost! Proceed loading?", "Potential Data Loss", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
					return;
				this.orderService.Orders = newService.Orders;
			} catch (Exception ex) {
				Utility.ShowErrorDialogue(ex.Message);
			}
			this.bindingSourceOrders.DataSource = this.orderService.Orders;
			this.dataGridViewOrders.ClearSelection();
			this.bindingSourceOrderDetails.DataSource = null;
			this.bindingSourceOrders.ResetBindings(false);
			this.bindingSourceOrderDetails.ResetBindings(false);
			Utility.ShowInfoDialogue("Orders loaded successfully!");
		} else {
			Utility.ShowErrorDialogue("Loading has been cancelled!");
		}
	}

	private void checkBoxCustomer_CheckedChanged(object sender, EventArgs e) {
		this.textBoxQueryCustomerAddress.Enabled = this.checkBoxCustomer.Checked;
		this.textBoxQueryCustomerName.Enabled = this.checkBoxCustomer.Checked;
	}

	private void checkBoxPrice_CheckedChanged(object sender, EventArgs e) {
		this.numericUpDownQueryMin.Enabled = this.checkBoxPrice.Checked;
		this.numericUpDownQueryMax.Enabled = this.checkBoxPrice.Checked;
	}

	private void checkBoxOrderTime_CheckedChanged(object sender, EventArgs e) {
		this.dateTimePickerQueryFrom.Enabled = this.checkBoxOrderTime.Checked;
		this.dateTimePickerQueryTo.Enabled = this.checkBoxOrderTime.Checked;
	}

	private void checkBoxItem_CheckedChanged(object sender, EventArgs e) {
		this.textBoxQueryItemName.Enabled = this.checkBoxItem.Checked;
	}

	private void buttonQuery_Click(object sender, EventArgs e) {
		this.queriedOrders = this.orderService.Find((order) => {
			return true &&
			       (!this.checkBoxCustomer.Checked || order.Customer.Equals(new Customer(this.textBoxQueryCustomerName.Text, this.textBoxQueryCustomerAddress.Text))) &&
			       (!this.checkBoxItem.Checked || order.HasItemName(this.textBoxQueryItemName.Text)) &&
			       (!this.checkBoxOrderTime.Checked || order.OrderTime >= this.dateTimePickerQueryFrom.Value && order.OrderTime <= this.dateTimePickerQueryTo.Value) &&
			       (!this.checkBoxPrice.Checked || order.Price >= decimal.ToDouble(this.numericUpDownQueryMin.Value) && order.Price <= decimal.ToDouble(this.numericUpDownQueryMax.Value));
		});
		this.bindingSourceOrders.DataSource = this.queriedOrders;
		this.dataGridViewOrders.ClearSelection();
		this.bindingSourceOrderDetails.DataSource = null;
		this.bindingSourceOrders.ResetBindings(false);
		this.bindingSourceOrderDetails.ResetBindings(false);
		Utility.ShowInfoDialogue("Query completed successfully!");
	}

	private void tabControl1_Selected(object sender, TabControlEventArgs e) {
		this.bindingSourceOrders.DataSource = this.tabControl1.SelectedIndex == 2 ? this.queriedOrders : this.orderService.Orders;
		this.dataGridViewOrders.ClearSelection();
		this.bindingSourceOrderDetails.DataSource = null;
		this.bindingSourceOrders.ResetBindings(false);
		this.bindingSourceOrderDetails.ResetBindings(false);
	}
}
