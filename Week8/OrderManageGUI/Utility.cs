namespace OrderManageGUI;

internal class Utility {
	public static void ShowErrorDialogue(string message) {
		MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
	}

	public static void ResizeLabel(ref Label L, float ratio = 0.80F) {
		SizeF extent = TextRenderer.MeasureText(L.Text, L.Font);

		var hR = L.Height / extent.Height;
		var wR = L.Width / extent.Width;
		var R = ratio * (hR < wR ? hR : wR);

		L.Font = new Font(L.Font.FontFamily, R * L.Font.Size, L.Font.Style);
	}
}