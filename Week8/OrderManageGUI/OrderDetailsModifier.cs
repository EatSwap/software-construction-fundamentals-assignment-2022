namespace OrderManageGUI;

using OrderManageCLI;

public partial class OrderDetailsModifier : Form {
	public OrderDetailsModifier(List<OrderDetails>? details = null) {
		this.InitializeComponent();

		OrderDetailsList = details ?? new List<OrderDetails>();
		bindingSourceOrderDetails.DataSource = OrderDetailsList;
	}

	public List<OrderDetails> OrderDetailsList { get; }

	private void buttonDone_Click(object sender, EventArgs e) {
		this.Close();
	}

	private void buttonRemove_Click(object sender, EventArgs e) {
		foreach (object? i in dataGridViewOrderDetails.SelectedRows)
			if (i is DataGridViewRow {DataBoundItem: OrderDetails d})
				OrderDetailsList.Remove(d);
		bindingSourceOrderDetails.ResetBindings(false);
	}

	private void buttonAdd_Click(object sender, EventArgs e) {
		if (string.IsNullOrEmpty(textBoxItemName.Text)) {
			Utility.ShowErrorDialogue("Item name shall not be empty");
			return;
		}

		OrderDetailsList.Add(new OrderDetails(textBoxItemName.Text, decimal.ToDouble(numericUpDownUnitPrice.Value), decimal.ToInt32(numericUpDownCount.Value)));
		bindingSourceOrderDetails.ResetBindings(false);
	}

	private void buttonClear_Click(object sender, EventArgs e) {
		OrderDetailsList.Clear();
		bindingSourceOrderDetails.ResetBindings(false);
	}

	private void numericUpDownUnitPrice_ValueChanged(object sender, EventArgs e) {
		Utility.ShowErrorDialogue("Value changed to " + numericUpDownUnitPrice.Value.ToString());
		; // debug
	}
}