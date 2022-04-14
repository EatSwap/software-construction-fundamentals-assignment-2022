namespace OrderManageGUI;

using OrderManageCLI;

public partial class OrderDetailsModifier : Form {
	public OrderDetailsModifier(List<OrderDetails>? details = null) {
		this.InitializeComponent();

		this.OrderDetailsList = details ?? new List<OrderDetails>();
		this.bindingSourceOrderDetails.DataSource = this.OrderDetailsList;
	}

	public List<OrderDetails> OrderDetailsList { get; }

	private void buttonDone_Click(object sender, EventArgs e) {
		this.Close();
	}

	private void buttonRemove_Click(object sender, EventArgs e) {
		foreach (object? i in this.dataGridViewOrderDetails.SelectedRows)
			if (i is DataGridViewRow {DataBoundItem: OrderDetails d})
				this.OrderDetailsList.Remove(d);
		this.bindingSourceOrderDetails.ResetBindings(false);
	}

	private void buttonAdd_Click(object sender, EventArgs e) {
		if (string.IsNullOrEmpty(this.textBoxItemName.Text)) {
			Utility.ShowErrorDialogue("Item name shall not be empty");
			return;
		}

		this.OrderDetailsList.Add(new OrderDetails(this.textBoxItemName.Text, decimal.ToDouble(this.numericUpDownUnitPrice.Value), decimal.ToInt32(this.numericUpDownCount.Value)));
		this.bindingSourceOrderDetails.ResetBindings(false);
	}

	private void buttonClear_Click(object sender, EventArgs e) {
		this.OrderDetailsList.Clear();
		this.bindingSourceOrderDetails.ResetBindings(false);
	}

	private void numericUpDownUnitPrice_ValueChanged(object sender, EventArgs e) {
		Utility.ShowErrorDialogue("Value changed to " + this.numericUpDownUnitPrice.Value);
		; // debug
	}
}
