using System.Text.RegularExpressions;

namespace ConsoleCalculator {
	public class ConsoleCalculatorEntry {
		public static void Main() {
			var expressionMatching = new Regex("\\s{0,}(?<numA>-{0,1}[0-9\\.]{1,})\\s{0,}(?<op>[+\\-*\\/%^&|])\\s{0,}(?<numB>-{0,1}[0-9\\.]{1,})");
			
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

			double dA = double.Parse(numA), dB = double.Parse(numB);
			bool isFloatingPointArithmetic = numA.Contains('.') || numB.Contains('.') || Math.Abs(dA) > long.MaxValue || Math.Abs(dB) > long.MaxValue;
			long lA = isFloatingPointArithmetic ? 0 : long.Parse(numA), lB = isFloatingPointArithmetic ? 0 : long.Parse(numB);
			
			switch (op[0]) {
				case '+':
					if (isFloatingPointArithmetic) {
						Console.WriteLine(dA + dB);
					} else {
						Console.WriteLine(lA + lB);
					}
					break;
				case '-':
					if (isFloatingPointArithmetic) {
						Console.WriteLine(dA - dB);
					} else {
						Console.WriteLine(lA - lB);
					}
					break;
				case '*':
					if (isFloatingPointArithmetic) {
						Console.WriteLine(dA * dB);
					} else {
						Console.WriteLine(lA * lB);
					}
					break;
				case '/':
					Console.WriteLine(dA / dB);
					break;
				case '^':
					if (isFloatingPointArithmetic) {
						Console.WriteLine("Invalid operation xor on floating-point number");
					} else {
						Console.WriteLine(lA ^ lB);
					}
					break;
				case '&':
					if (isFloatingPointArithmetic) {
						Console.WriteLine("Invalid operation bit-and on floating-point number");
					} else {
						Console.WriteLine(lA & lB);
					}
					break;
				case '%':
					if (isFloatingPointArithmetic) {
						Console.WriteLine(dA % dB);
					} else {
						Console.WriteLine(lA % lB);
					}
					break;
				case '|':
					if (isFloatingPointArithmetic) {
						Console.WriteLine("Invalid operation bit-or on floating-point number");
					} else {
						Console.WriteLine(lA | lB);
					}
					break;
				default:
					throw new Exception("code should not reach here");
			}
		}
	}
}