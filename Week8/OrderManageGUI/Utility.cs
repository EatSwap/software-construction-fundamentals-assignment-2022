namespace OrderManageGUI;

internal class Utility {
	public static void ShowErrorDialogue(string message) {
		MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
	}

	public static void ShowInfoDialogue(string message) {
		MessageBox.Show(message, "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
	}

	public static void ResizeLabel(ref Label L, float ratio = 0.80F) {
		SizeF extent = TextRenderer.MeasureText(L.Text, L.Font);

		float hR = L.Height / extent.Height;
		float wR = L.Width / extent.Width;
		float R = ratio * (hR < wR ? hR : wR);

		L.Font = new Font(L.Font.FontFamily, R * L.Font.Size, L.Font.Style);
	}
}
