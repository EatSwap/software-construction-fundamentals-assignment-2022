using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManageCLI;

namespace OrderManageGUI;
public partial class OrderDetailsModifier : Form {
    private List<OrderDetails> orderDetailsList;

    public double CurrentUnitPrice { get; set; }

    public int currentCount { get; set; }

    public OrderDetailsModifier(List<OrderDetails>? details = null) {
        InitializeComponent();

        orderDetailsList = details ?? new List<OrderDetails>();
        this.bindingSourceOrderDetails.DataSource = orderDetailsList;

        this.numericUpDownUnitPrice.DataBindings.Add("Value", this, "currentUnitPrice");
        this.numericUpDownCount.DataBindings.Add("Value", this, "currentCount");
		// this.textBoxItemName.DataBindings.Add("Text", this, "currentItemName");
	}

	public List<OrderDetails> OrderDetailsList => orderDetailsList;

	private void buttonDone_Click(object sender, EventArgs e) {
        this.Close();
	}

	private void buttonRemove_Click(object sender, EventArgs e) {
        this.dataGridViewOrderDetails.SelectedRows.Cast<OrderDetails>().ToList().ForEach(orderDetails => orderDetailsList.Remove(orderDetails));
        this.bindingSourceOrderDetails.DataSource = orderDetailsList;
	}

	private void buttonAdd_Click(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(this.textBoxItemName.Text)) {
            Utility.ShowErrorDialogue("Item name shall not be empty");
            return;
        }
        this.orderDetailsList.Add(new OrderDetails(this.textBoxItemName.Text, CurrentUnitPrice, currentCount));
        this.bindingSourceOrderDetails.ResetBindings(false);
    }
}
