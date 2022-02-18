using System.Text.RegularExpressions;

namespace ConsoleCalculator {
	public class ConsoleCalculatorEntry {
		public static void Main() {
			var expressionMatching = new Regex("\\s{0,}(?<numA>-{0,1}[0-9\\.]{1,})\\s{0,}(?<op>[+\\-*\\/%^&])\\s{0,}(?<numB>-{0,1}[0-9\\.]{1,})");
			
			Console.Write("Type your expression, then press <Enter>: ");
			var line = Console.ReadLine();
			
			if (line == null) {
				throw new Exception("got null pointer when reading one line");
			}

			var regexMatch = expressionMatching.Match(line);
			if (!regexMatch.Success) {
				Console.WriteLine("Your input seems to be invalid.");
				return;
			}

			var numA = regexMatch.Groups["numA"].Value;
			var numB = regexMatch.Groups["numB"].Value;
			var op = regexMatch.Groups["op"].Value;

			bool isFloatingPointArithmetic = numA.Contains('.') || numB.Contains('.');
			
			switch (op[0]) {
				case '+':
					if (isFloatingPointArithmetic) {
						Console.WriteLine(double.Parse(numA) + double.Parse(numB));
					} else {
						Console.WriteLine(long.Parse(numA) + long.Parse(numB));
					}
					break;
				case '-':
					if (isFloatingPointArithmetic) {
						Console.WriteLine(double.Parse(numA) - double.Parse(numB));
					} else {
						Console.WriteLine(long.Parse(numA) - long.Parse(numB));
					}
					break;
				case '*':
					if (isFloatingPointArithmetic) {
						Console.WriteLine(double.Parse(numA) * double.Parse(numB));
					} else {
						Console.WriteLine(long.Parse(numA) * long.Parse(numB));
					}
					break;
				case '/':
					Console.WriteLine(double.Parse(numA) / double.Parse(numB));
					break;
				case '^':
					if (isFloatingPointArithmetic) {
						Console.WriteLine("Invalid operation xor on floating-point number");
					} else {
						Console.WriteLine(long.Parse(numA) ^ long.Parse(numB));
					}
					break;
				case '&':
					if (isFloatingPointArithmetic) {
						Console.WriteLine("Invalid operation bit-and on floating-point number");
					} else {
						Console.WriteLine(long.Parse(numA) & long.Parse(numB));
					}
					break;
				case '%':
					if (isFloatingPointArithmetic) {
						Console.WriteLine(double.Parse(numA) % double.Parse(numB));
					} else {
						Console.WriteLine(long.Parse(numA) % long.Parse(numB));
					}
					break;
				case '|':
					if (isFloatingPointArithmetic) {
						Console.WriteLine("Invalid operation bit-or on floating-point number");
					} else {
						Console.WriteLine(long.Parse(numA) | long.Parse(numB));
					}
					break;
				default:
					throw new Exception("code should not reach here");
			}
		}
	}
}