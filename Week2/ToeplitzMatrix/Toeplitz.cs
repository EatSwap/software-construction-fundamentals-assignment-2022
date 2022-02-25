namespace ToeplitzMatrix;

public class Toeplitz {
	public static bool IsToeplitz(int[][] matrix) {
		if (matrix.Length == 0 || matrix[0].Length == 0) {
			return false;
		} else if (matrix.Length == 1) {
			return true;
		}

		var m = matrix.Length;
		var n = matrix[0].Length;

		var k = m < n ? m : n;
		var baseLine = matrix[0][0];
		for (int i = 1; i < k; ++i) {
			if (matrix[i].Length != n) {
				throw new Exception("argument is not a matrix");
			} else if (matrix[i][i] != baseLine) {
				return false;
			}
		}

		return true;
	}
}
