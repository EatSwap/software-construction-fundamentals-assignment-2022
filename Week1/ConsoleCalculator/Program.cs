using System.Text.RegularExpressions;

namespace ConsoleCalculator;

public class ConsoleCalculatorEntry {
	public static void Main() {
		var expressionMatching = new Regex("^\\s*(?<numA>[-+]?\\d*\\.?\\d+([eE][-+]?\\d+)?)\\s*(?<op>[+\\-*\\/%^&|])\\s*(?<numB>[-+]?\\d*\\.?\\d+([eE][-+]?\\d+)?)\\s*$");

		Console.Write("Type your expression, then press <Enter>: ");
		var line = Console.ReadLine();

		if (line == null) throw new Exception("got null pointer when reading one line");

		var regexMatch = expressionMatching.Match(line);
		if (!regexMatch.Success) {
			Console.WriteLine("Your input seems to be invalid.");
			return;
		}

		var numA = regexMatch.Groups["numA"].Value;
		var numB = regexMatch.Groups["numB"].Value;
		var op = regexMatch.Groups["op"].Value;

		string result;
		try {
			result = Calculate(numA, numB, op[0]);
		}
		catch (Exception e) {
			result = e.Message;
		}

		Console.WriteLine(result);
	}

	private static string Calculate(string numA, string numB, char operation) {
		if (!double.TryParse(numA, out double dA) | !double.TryParse(numB, out double dB)) {
			throw new Exception("At least one operand could not be parsed as valid number.");
		}
		var isFloatingPointArithmetic = numA.Contains('.') || numB.Contains('.') || Math.Abs(dA) > long.MaxValue || Math.Abs(dB) > long.MaxValue;
		isFloatingPointArithmetic |= !long.TryParse(numA, out long lA) | !long.TryParse(numB, out long lB);

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
			if (dB == 0.0)
				throw new Exception("cannot divide by zero");
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
			if (dB == 0.0 || (!isFloatingPointArithmetic && lB == 0))
				throw new Exception("cannot divide by zero");
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

		throw new Exception("unrecognised operator " + operation);
	}
}