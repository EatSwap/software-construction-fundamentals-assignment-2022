using System;
using System.Drawing;
using System.Windows.Forms;

namespace CayleyTree {
	public partial class Form1 : Form {
		private readonly double per1 = 0.6;
		private readonly double per2 = 0.7;
		private readonly double th1 = 30 * Math.PI / 180;
		private readonly double th2 = 20 * Math.PI / 180;
		private int n = 11;
		private double stemLength = 100.0;
		private Graphics graphics;

		public Form1() {
			InitializeComponent();
			AutoScaleBaseSize = new Size(6, 140);
			ClientSize = new Size(600, 300);
		}
		private void Form1_Load(object sender, EventArgs e) {
			// Does nothing.
		}

		private static void showErrorMessage(string message) {
			MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		private static double tryParseDouble(string str, string componentName, double maxRange) {
			if (double.TryParse(str, out double d)) {
				return d;
			} else {
				showErrorMessage($"{componentName} 的输入须在 [0, {maxRange}] 范围内！");
				throw new ArgumentOutOfRangeException();
			}
		}

		private void drawCayleyTree(int n, double x0, double y0, double stemLen, double th) {
			if (n == 0) return;

			var x1 = x0 + stemLen * Math.Cos(th);
			var y1 = y0 + stemLen * Math.Sin(th);

			drawLine(x0, y0, x1, y1);

			drawCayleyTree(n - 1, x1, y1, per1 * stemLen, th + th1);
			drawCayleyTree(n - 1, x1, y1, per2 * stemLen, th - th2);
		}

		private void drawLine(double x0, double y0, double x1, double y1) {
			graphics.DrawLine(Pens.Blue, (int) x0, (int) y0, (int) x1, (int) y1);
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e) {
			this.graphics = e.Graphics;
			drawCayleyTree(n, 200, 310, stemLength, -Math.PI / 2);
		}

        private void remakeButton_Click(object sender, EventArgs e) {
			// Try parsing recursion depth
			try {
				n = (int) tryParseDouble(textBoxRecursionDepth.Text, "递归深度", 30);
				stemLength = (int) tryParseDouble(textBoxStemLength.Text, "主干长度", 300);
			} catch (ArgumentOutOfRangeException) {
				return;
			}

			drawingPanel.Refresh();
        }
    }
}