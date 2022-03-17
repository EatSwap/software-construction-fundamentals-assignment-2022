using System.Text;

namespace OrderManageCLI;

public class Demo {
	public static void Main() {
		string s1 = "gugu";
		string s2 = "gu" + "gu";
		Console.WriteLine("Not Implemented Yet.");
		Console.WriteLine(s1.GetHashCode());
		Console.WriteLine(s2.GetHashCode());
		var sb = new StringBuilder();
		sb.AppendFormat("%d%d", 1, 2);
		Console.WriteLine(sb.ToString());
	}
}
