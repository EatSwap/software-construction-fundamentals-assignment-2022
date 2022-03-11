namespace LinkedListForEach;

public class Demo {
	public static void Main() {
		var stringList = new GenericList<string>();
		
		stringList.Add("gugu");
		stringList.Add("guagua");
		stringList.Add("guagu");
		stringList.Add("guaguagu");
		stringList.Add("guaguaguagu");

		foreach (var str in stringList) {
			Console.WriteLine(str);
		}
	}
}
