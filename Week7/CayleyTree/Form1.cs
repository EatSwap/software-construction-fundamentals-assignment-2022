using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CayleyTree {
	public partial class Form1 : Form {
		private double per1 = 0.6;
		private double per2 = 0.7;

		private double th1 = 30 * Math.PI / 180;
		private double th2 = 20 * Math.PI / 180;

		private int n = 11;

		private double stemLength = 100.0;

		private Pen pen = new Pen(Color.Black);

		private bool canPaint = false;

		private int pivotX = 200;
		private int pivotY = 310;

		public Form1() {
			InitializeComponent();
			AutoScaleBaseSize = new Size(6, 140);
			ClientSize = new Size(600, 300);
		}

		private void Form1_Load(object sender, EventArgs e) {
			// Pre-define the pen colour <- black.
			comboBoxPenColour.SelectedIndex = 7;

			// Progress bar step
			toolStripProgressBar1.Step = 1;
		}

		private static void showErrorMessage(string message) {
			MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		private static double tryParseDouble(string str, string componentName, double maxRange) {
			if (double.TryParse(str, out double d) && d <= maxRange) {
				return d;
			} else {
				showErrorMessage($"{componentName} 的输入须在 [0, {maxRange}] 范围内！");
				throw new ArgumentOutOfRangeException();
			}
		}

        private void drawingPanel_Paint(object sender, PaintEventArgs e) {
			if (!canPaint) return;

			toolStripProgressBar1.Maximum = (1 << n) - 1;

			Action<int, double, double, double, double> drawCayleyTree = null;
			drawCayleyTree = (n, x0, y0, stemLen, th) => {
				if (n == 0) return;
				var x1 = x0 + stemLen * Math.Cos(th);
				var y1 = y0 + stemLen * Math.Sin(th);

				e.Graphics.DrawLine(pen, (int) x0, (int) y0, (int) x1, (int) y1);

				toolStripProgressBar1.PerformStep();

				drawCayleyTree(n - 1, x1, y1, per1 * stemLen, th + th1);
				drawCayleyTree(n - 1, x1, y1, per2 * stemLen, th - th2);
			};

			var stopWatch = new Stopwatch();
			stopWatch.Start();
			drawCayleyTree(n, pivotX, pivotY, this.stemLength, -Math.PI / 2);
			stopWatch.Stop();

			toolStripStatusLabel1.Text = $"Total steps: {(1 << n) - 1}, Time Elapsed: {stopWatch.ElapsedMilliseconds} ms";
		}

        private void remakeButton_Click(object sender, EventArgs e) {
			// Try parsing recursion depth
			try {
				n = (int) tryParseDouble(textBoxRecursionDepth.Text, "递归深度", 30);
				stemLength = tryParseDouble(textBoxStemLength.Text, "主干长度", 300);
				per1 = tryParseDouble(textBoxPer1.Text, "右分支长度比", 1.0);
				per2 = tryParseDouble(textBoxPer2.Text, "左分支长度比", 1.0);
				th1 = (Math.PI / 180) * tryParseDouble(textBoxTh1.Text, "右分支角度", 180.0);
				th2 = (Math.PI / 180) * tryParseDouble(textBoxTh2.Text, "左分支角度", 180.0);
				pen = new Pen(Color.FromName(comboBoxPenColour.Text));
			} catch (ArgumentOutOfRangeException) {
				canPaint = false;
				return;
			}
			canPaint = true;
			pivotX = drawingPanel.Width / 2;
			pivotY = drawingPanel.Height;
			drawingPanel.Refresh();
        }
    }
}