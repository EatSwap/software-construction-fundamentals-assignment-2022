using OrderManageCLI;

namespace OrderManageGUI;

public partial class OrderDetailsModifier : Form {
	public OrderDetailsModifier(List<OrderDetails>? details = null) {
		InitializeComponent();

		OrderDetailsList = details ?? new List<OrderDetails>();
		bindingSourceOrderDetails.DataSource = OrderDetailsList;

		numericUpDownUnitPrice.DataBindings.Add("Value", this, "currentUnitPrice");
		numericUpDownCount.DataBindings.Add("Value", this, "currentCount");
		// this.textBoxItemName.DataBindings.Add("Text", this, "currentItemName");
	}

	public double CurrentUnitPrice { get; set; }

	public int currentCount { get; set; }

	public List<OrderDetails> OrderDetailsList { get; }

	private void buttonDone_Click(object sender, EventArgs e) {
		Close();
	}

	private void buttonRemove_Click(object sender, EventArgs e) {
		foreach (var i in dataGridViewOrderDetails.SelectedRows) {
			if (!(i is DataGridViewRow r) || !(r.DataBoundItem is OrderDetails d))
				continue;
			OrderDetailsList.Remove(d);
		}
		bindingSourceOrderDetails.ResetBindings(false);
	}

	private void buttonAdd_Click(object sender, EventArgs e) {
		if (string.IsNullOrEmpty(textBoxItemName.Text)) {
			Utility.ShowErrorDialogue("Item name shall not be empty");
			return;
		}

		OrderDetailsList.Add(new OrderDetails(textBoxItemName.Text, CurrentUnitPrice, currentCount));
		bindingSourceOrderDetails.ResetBindings(false);
	}

	private void buttonClear_Click(object sender, EventArgs e) {
		OrderDetailsList.Clear();
		bindingSourceOrderDetails.ResetBindings(false);
	}
}