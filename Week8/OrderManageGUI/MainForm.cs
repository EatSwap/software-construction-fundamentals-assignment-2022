using OrderManageCLI;

namespace OrderManageGUI;

public partial class MainForm : Form {
    private OrderService orderService = new();

    private List<OrderDetails> orderDetailsList = new();

    public MainForm() {
        InitializeComponent();
    }
    
    private static void ResizeLabel(ref Label L, float ratio = 0.80F) {
        SizeF extent = TextRenderer.MeasureText(L.Text, L.Font);

        var hR = L.Height / extent.Height;
        var wR = L.Width / extent.Width;
        var R = ratio * ((hR < wR) ? hR : wR);

        L.Font = new Font(L.Font.FontFamily, R * L.Font.Size, L.Font.Style);
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
        var modifyForm = new OrderDetailsModifier(orderDetailsList);
        modifyForm.ShowDialog();
    }

	private void buttonCreateOrder_Click(object sender, EventArgs e) {
       // this.orderService.AddOrder(new Order(new Customer()))
	}
}
