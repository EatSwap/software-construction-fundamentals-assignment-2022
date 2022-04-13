using OrderManageCLI;

namespace OrderManageGUI;

public partial class MainForm : Form {
    private OrderService orderService = new();

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

        var getOrderDetails = () => {
            var odList = new List<OrderDetails>();
            int cnt = rnd.Next(15);
            while (cnt-- > 0) {
                odList.Add(new OrderDetails($"Product {'a' + rnd.Next(26)}{'a' + rnd.Next(26)}{'a' + rnd.Next(26)}{'a' + rnd.Next(26)}{'a' + rnd.Next(26)}", rnd.NextDouble(), rnd.Next(100)));
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
            var order = dataGridViewOrders.CurrentRow.DataBoundItem as Order;
            bindingSourceOrderDetails.DataSource = order?.OrderDetails;
        } catch {
            // Does nothing
            // I still cannot understand where this "IndexOutOfBoundException" comes.
        }
    }
}
