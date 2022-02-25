namespace PrimeFactor; 

public class Entry {
	public static void Main() {
		Console.Write("Give me a integer: ");
		var line = Console.ReadLine();

		if (line == null) {
			Console.WriteLine("null reference was read");
			return;
		}

		if (!long.TryParse(line, out long x)) {
			Console.WriteLine("not a valid integer");
			return;
		}

		if (x < 0) {
			Console.WriteLine("prime factors of integers which is less than 1 is not defined");
			return;
		}

		var ans = Prime.GetPrimeFactors(x);
		Console.Write("Prime factors of " + x + " is:");
		foreach (long i in ans) {
			Console.Write(" " + i);
		}
	}
}