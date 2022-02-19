using System;
using System.Windows;

namespace CalculatorGUI; 

public partial class MainWindow : Window {
	public MainWindow() {
		InitializeComponent();
	}

	private void DoCalculate(object sender, RoutedEventArgs e) {
		var numA = FirstOperand.Text;
		var numB = SecondOperand.Text;
		var op = OperatorSelector.Text;

		// Test for null operator
		if (string.IsNullOrEmpty(op)) {
			MessageBox.Show("Please select an operator", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		
		// Test for empty operands
		if (string.IsNullOrEmpty(numA) || string.IsNullOrEmpty(numB)) {
			MessageBox.Show("Please enter both operands", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		
		string result;
		try {
			result = Calculate(numA, numB, op[0]);
		} catch (Exception ex) {
			MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		
		Result.Text = result;
	}

	private static string Calculate(string numA, string numB, char operation) {
		if (!double.TryParse(numA, out var dA) | !double.TryParse(numB, out var dB)) throw new Exception("At least one operand could not be parsed as valid number.");
		var isFloatingPointArithmetic = numA.Contains('.') || numB.Contains('.') || Math.Abs(dA) > long.MaxValue || Math.Abs(dB) > long.MaxValue;
		isFloatingPointArithmetic |= !long.TryParse(numA, out var lA) | !long.TryParse(numB, out var lB);

		switch (operation) {
		case '+':
			if (isFloatingPointArithmetic)
				return "" + (dA + dB);
			else
				return "" + (lA + lB);
		case '-':
			if (isFloatingPointArithmetic)
				return "" + (dA - dB);
			else
				return "" + (lA - lB);
		case '*':
			if (isFloatingPointArithmetic)
				return "" + dA * dB;
			else
				return "" + lA * lB;
		case '/':
			return "" + dA / dB;
		case '^':
			if (isFloatingPointArithmetic)
				throw new Exception("Invalid operation xor on floating-point number");
			else
				return "" + (lA ^ lB);
		case '&':
			if (isFloatingPointArithmetic)
				throw new Exception("Invalid operation bit-and on floating-point number");
			else
				return "" + (lA & lB);
		case '%':
			if (isFloatingPointArithmetic)
				return "" + dA % dB;
			else
				return "" + lA % lB;
		case '|':
			if (isFloatingPointArithmetic)
				throw new Exception("Invalid operation bit-or on floating-point number");
			else
				return "" + (lA | lB);
		}

		throw new Exception("code considered unreachable reached");
	}
}