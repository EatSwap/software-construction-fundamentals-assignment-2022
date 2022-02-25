namespace ArrayArithmetic; 

public class Demo {
	public static void Main() {
		Console.Write("Give me some integer, seperated by spaces: ");
		var line = Console.ReadLine();

		if (line == null) {
			Console.WriteLine("null reference was read");
			return;
		}

		var numStrings = line.Split(' ');
		var n = numStrings.Length;
		
		var arr = new int[n];

		for (int i = 0; i < n; ++i) {
			if (!int.TryParse(numStrings[i], out int x)) {
				Console.WriteLine("invalid input at input # " + i);
				return;
			}

			arr[i] = x;
		}
		
		Console.WriteLine("Max: " + ArrayArithmetic.Max(arr));
		Console.WriteLine("Min: " + ArrayArithmetic.Min(arr));
		Console.WriteLine("Sum: " + ArrayArithmetic.Sum(arr));
		Console.WriteLine("Avg: " + ArrayArithmetic.Average(arr));
	}
}