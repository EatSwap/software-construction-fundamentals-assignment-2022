namespace SieveOfEratosthenes; 

public class Demo {
	public static void Main() {
		Console.Write("Give me a integer x and I will find all primes less than x: ");
		var line = Console.ReadLine();

		if (line == null) {
			Console.WriteLine("null reference was read");
			return;
		}

		if (!long.TryParse(line, out long x)) {
			Console.WriteLine("invalid input");
			return;
		}

		var ans = Eratosthenes.GetPrimes(x);
		Console.Write("Primes less than " + x + ":");
		foreach (long i in ans) {
			Console.Write(" " + i);
		}
	}
}