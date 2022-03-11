namespace LinkedListForEach;

public class Demo {
	public static void Main() {
		var numList = new GenericList<int>();
		
		numList.Add(1);
		numList.Add(2);
		numList.Add(9999999);
		numList.Add(3);
		numList.Add(4567890);
		numList.Add(4);
		
		numList.ForEach(Console.WriteLine);
		
		Console.Write("Min: ");
		int min = 0x7FFFFFFF;
		numList.ForEach(x => min = Math.Min(min, x));
		Console.WriteLine(min);
		
		Console.Write("Max: ");
		int max = (-0x7FFFFFFF) - 1;
		numList.ForEach(x => max = Math.Max(max, x));
		Console.WriteLine(max);
		
		Console.Write("Sum: ");
		int sum = 0;
		numList.ForEach(x => sum += x);
		Console.WriteLine(sum);
		
		Console.Write("Average: ");
		double average = 0;
		int cnt = 0;
		numList.ForEach(x => {
			average += x;
			cnt++;
		});
		average /= cnt;
		Console.WriteLine(average);
	}
}
