namespace PrimeFactor;

public class Prime {
	public static long[] GetPrimeFactors(long x) {
		var ret = new List<long>();

		long limit = Convert.ToInt64(Math.Sqrt(Convert.ToDouble(x))) + 1;
		for (long i = 2; x > 1 && i <= limit; ++i) {
			while (x % i == 0) {
				ret.Add(i);
				x /= i;
			}
		}
		
		if (x != 1)
			ret.Add(x);

		return ret.ToArray();
	}
}
