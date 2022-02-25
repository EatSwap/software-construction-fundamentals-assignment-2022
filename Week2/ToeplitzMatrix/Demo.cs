namespace ToeplitzMatrix; 

public class Demo {
	public static void Main() {
		int[][] args = {
			new int[] {1, 2, 3, 4},
			new int[] {5, 1, 2, 3},
			new int[] {9, 5, 1, 2}
		};
		
		Console.WriteLine(Toeplitz.IsToeplitz(args));
	}
}