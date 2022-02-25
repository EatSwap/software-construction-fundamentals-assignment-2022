namespace ToeplitzMatrix;

public class Toeplitz {
	public static bool IsToeplitz(int[,] matrix) {
		int m = matrix.Length, n = matrix.GetLength(0);
		
		if (m == 0 || n == 0)
			return false;
		else if (m == 1)
			return true;
		
		// Does not check if x, y are valid
		var verdict = (int x, int y) => {
			int baseLine = matrix[x, y];
			for (int i = 1; i + x < m && i + y < n; ++i)
				if (matrix[i + x, i + y] != baseLine)
					return false;
			return true;
		};
		
		// In x direction
		for (int i = 1; i < n; ++i)
			if (!verdict(0, i))
				return false;

		// In y direction
		for (int i = 1; i < m; ++i)
			if (!verdict(i, 0))
				return false;

		return verdict(0, 0);
	}
}
