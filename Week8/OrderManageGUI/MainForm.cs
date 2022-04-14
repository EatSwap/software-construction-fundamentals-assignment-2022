using OrderManageCLI;

namespace OrderManageGUI;

public partial class MainForm : Form {
    private OrderService orderService = new();

    private List<OrderDetails> currentOrderDetailsList = new();

    public string CurrentCustomerName { get; set; }

    public string CurrentCustomerAddress { get; set; }

    public DateTime CurrentOrderTime { get; set; }

    public MainForm() {
        InitializeComponent();
    }

    private void GenerateRandomOrders() {
        var rnd = new Random();
        var randomOrders = new Order[100];

        var randomChar = () => (char)('a' + rnd.Next(26));
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
            while (cnt --> 0) {
                odList.Add(new OrderDetails($"Product {randomChar()}{randomChar()}{randomChar()}{randomChar()}{randomChar()}", rnd.NextDouble(), rnd.Next(100)));
            }
            return odList.ToArray();
        };

        for (int i = 0; i < 100; ++i) {
            randomOrders[i] = new Order(new Customer($"Name {i}", $"Address {i}"), new DateTime(1923 + rnd.Next(100), 1 + rnd.Next(12), 1 + rnd.Next(28)), getOrderDetails());
            this.orderService.AddOrder(randomOrders[i]);
        }
    }

    private void MainForm_Load(object sender, EventArgs e) {
        GenerateRandomOrders();
        this.bindingSourceOrders.DataSource = this.orderService.Orders;

        this.CurrentOrderTime = DateTime.Now;
        this.textBoxCreateCustomerName.DataBindings.Add("Text", this, nameof(CurrentCustomerAddress));
        this.textBoxCreateCustomerAddress.DataBindings.Add("Text", this, nameof(CurrentCustomerName));
        this.dateTimePickerCreateOrderTime.DataBindings.Add("Text", this, nameof(CurrentOrderTime));
    }

    private void MainForm_Resize(object sender, EventArgs e) {
        ;
    }

    private void DataGridViewOrders_SelectionChanged(object sender, EventArgs e) {
        try {
            var order = dataGridViewOrders.CurrentRow?.DataBoundItem as Order;
            bindingSourceOrderDetails.DataSource = order?.OrderDetails;
        } catch {
            // Does nothing
            // I still cannot understand where this "IndexOutOfBoundException" comes.
        }
    }

    private void buttonCreateModifyDetails_Click(object sender, EventArgs e) {
        var modifyForm = new OrderDetailsModifier(currentOrderDetailsList);
        modifyForm.ShowDialog();
        this.currentOrderDetailsList = modifyForm.OrderDetailsList;
    }

	private void buttonCreateOrder_Click(object sender, EventArgs e) {
        try {
            this.orderService.AddOrder(new Order(new Customer(CurrentCustomerName, CurrentCustomerAddress), CurrentOrderTime, currentOrderDetailsList.ToArray()));
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
}
