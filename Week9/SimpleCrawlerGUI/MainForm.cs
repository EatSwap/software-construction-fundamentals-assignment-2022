using System.Text.RegularExpressions;
using SimpleCrawler;

namespace SimpleCrawlerGUI;

public partial class MainForm : Form {
	public string StartUrl { get; set; }

	public MainForm() {
		InitializeComponent();
	}

	private void MainForm_Load(object sender, EventArgs e) {
		this.textBox1.Text = $"Simple Crawler GUI initialised at {DateTime.Now}";

		this.textBoxStartURL.DataBindings.Add("Text", this, nameof(StartUrl));
	}

	private void buttonStart_Click(object sender, EventArgs e) {
		var r = new Regex("(\\b(https?|ftp|file)://)?[-A-Za-z0-9+&@#/%?=~_|!:,.;]+[-A-Za-z0-9+&@#/%=~_|]");
		var m = r.Match(StartUrl);
		if (string.IsNullOrEmpty(StartUrl) || !m.Success) {
			MessageBox.Show("Your URL is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		var c = new Crawler(StartUrl);
		var uri = new Uri(StartUrl);
		c.SetDomain(uri.Host);

		this.textBox1.Text = $"[{DateTime.Now}] Simple Crawler GUI started crawling." + Environment.NewLine;

		c.OnStart += (s, e) => this.textBox1.Invoke(() => {
			this.textBox1.AppendText($"[{DateTime.Now}] Starting download {e.Url}");
			this.textBox1.AppendText(Environment.NewLine);
		});

		c.OnSuccess += (s, e) => this.textBox1.Invoke(() => {
			this.textBox1.AppendText($"[{DateTime.Now}] Successfully downloaded {e.Url}");
			this.textBox1.AppendText(Environment.NewLine);
		});

		c.OnError += (s, e) => this.textBox1.Invoke(() => {
			this.textBox1.AppendText($"[{DateTime.Now}] Error downloading {e.Url}, message {e.Message}");
			this.textBox1.AppendText(Environment.NewLine);
		});

		new Thread(c.Crawl).Start();
	}
}