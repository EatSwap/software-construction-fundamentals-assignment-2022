namespace SimpleCrawlerGUI;

public partial class MainForm : Form {
	public MainForm() {
		InitializeComponent();
	}

	private void MainForm_Load(object sender, EventArgs e) {
		this.textBox1.Text = $"Simple Crawler GUI initialised at {DateTime.Now}";
	}
}