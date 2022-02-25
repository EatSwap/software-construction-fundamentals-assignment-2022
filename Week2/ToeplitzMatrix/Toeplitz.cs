namespace ToeplitzMatrix;

public class Toeplitz {
	public static bool IsToeplitz(int[][] matrix) {
		if (matrix.Length == 0 || matrix[0].Length == 0) {
			return false;
		} else if (matrix.Length == 1) {
			return true;
		}

		int m = matrix.Length, n = matrix[0].Length;

		for (int i = 0; i < m; ++i) {
			if (matrix[i].Length != n) {
				throw new Exception("argument is not a matrix");
			}
		}
		
		int k = m < n ? m : n, lim = m < n ? n - m : m - n;
		
		if (m < n) {
			// Extend at x direction
			for (int i = 0; i <= lim; ++i) {
				var baseLine = matrix[0][i];
				for (int j = 1; j < k; ++j) {
					if (matrix[j][i + j] != baseLine) {
						return false;
					}
				}
			}
		}
		else {
			// Extend at y direction
			for (int i = 0; i <= lim; ++i) {
				var baseLine = matrix[i][0];
				for (int j = 1; j < k; ++j) {
					if (matrix[i + j][j] != baseLine) {
						return false;
					}
				}
			}
		}

		return true;
	}
}
