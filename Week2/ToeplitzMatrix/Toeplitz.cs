namespace ToeplitzMatrix;

public class Toeplitz {
	public static bool IsToeplitz(int[][] matrix) {
		if (matrix.Length == 0 || matrix[0].Length == 0)
			return false;
		else if (matrix.Length == 1)
			return true;

		int m = matrix.Length, n = matrix[0].Length;

		for (int i = 0; i < m; ++i)
			if (matrix[i].Length != n)
				throw new Exception("argument is not a matrix");
		
		int k = m < n ? m : n, lim = m < n ? n - m : m - n;
		
		for (int i = 0; i <= lim; ++i) {
			var baseLine = matrix[m < n ? 0 : i][m < n ? i : 0];
			for (int j = 1; j < k; ++j) {
				if (matrix[(m < n ? 0 : i) + j][(m < n ? i : 0) + j] != baseLine)
					return false;
			}
		}

		return true;
	}
}
