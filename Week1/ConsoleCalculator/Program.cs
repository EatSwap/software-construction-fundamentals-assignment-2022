using System.Text.RegularExpressions;

namespace ConsoleCalculator;

public class ConsoleCalculatorEntry {
	public static void Main() {
		var expressionMatching = new Regex("\\s{0,}(?<numA>-{0,1}[0-9\\.]{1,})\\s{0,}(?<op>[+\\-*\\/%^&|])\\s{0,}(?<numB>-{0,1}[0-9\\.]{1,})");

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
		double dA = double.Parse(numA), dB = double.Parse(numB);
		var isFloatingPointArithmetic = numA.Contains('.') || numB.Contains('.') || Math.Abs(dA) > long.MaxValue || Math.Abs(dB) > long.MaxValue;
		long lA = isFloatingPointArithmetic ? 0 : long.Parse(numA), lB = isFloatingPointArithmetic ? 0 : long.Parse(numB);
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