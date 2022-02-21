using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsCalculator {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
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

		private void Calculate_Click(object sender, EventArgs e) {
			string numA = OperandFirst.Text, numB = OperandSecond.Text;
			string op = OperatorSelector.Text;
			
			// Test for null operator
			if (string.IsNullOrEmpty(op)) {
				MessageBox.Show("Please select an operator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		
			// Test for empty operands
			if (string.IsNullOrEmpty(numA) || string.IsNullOrEmpty(numB)) {
				MessageBox.Show("Please enter both operands.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		
			string result;
			try {
				result = Calculate(numA, numB, op[0]);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		
			Result.Text = result;
		}
	}
}