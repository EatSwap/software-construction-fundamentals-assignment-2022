namespace SieveOfEratosthenes;

public class Eratosthenes {
	public static long[] GetPrimes(long limit) {
		bool[] isNotPrime = new bool[limit + 1];
		
		long maxTry = Convert.ToInt64(Math.Sqrt(Convert.ToDouble(limit))) + 1;
		for (long i = 2; i <= maxTry; ++i) {
			if (isNotPrime[i])
				continue;
			for (long j = i + i; j <= limit; j += i)
				isNotPrime[j] = true;
		}

		var ret = new List<long>();
		for (long i = 2; i <= limit; i++) {
			if (!isNotPrime[i])
				ret.Add(i);
		}

		return ret.ToArray();
	}
}