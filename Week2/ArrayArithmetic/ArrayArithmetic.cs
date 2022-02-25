namespace ArrayArithmetic;

public class ArrayArithmetic {
	public static int Max(int[] arr) {
		int ret = -0x7FFFFFFF - 1;
		
		foreach (int i in arr) {
			ret = ret > i ? ret : i;
		}

		return ret;
	}

	public static int Min(int[] arr) {
		int ret = 0x7FFFFFFF;
		
		foreach (int i in arr) {
			ret = ret < i ? ret : i;
		}

		return ret;
	}

	public static long Sum(int[] arr) {
		long ret = 0;

		foreach (int i in arr) {
			ret += i;
		}

		return ret;
	}

	public static double Average(int[] arr) {
		return Convert.ToDouble(Sum(arr)) / arr.Length;
	}
}
