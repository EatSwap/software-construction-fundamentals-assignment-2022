namespace ClockWithEvent; 

public class Demo {
	public static void Main() {
		var clock = new Clock(11, 59, 50);
		clock.SetAlarm(12, 0, 2);

		clock.Tick += (sender, args) => {
			Console.WriteLine($"Clock ticked at {args.Hour}h {args.Minute}m {args.Second}s.");
		};
		
		clock.Alarm += (sender) => {
			Console.WriteLine($"Alarm!!!!!");
		};

		for (int i = 0; i < 30; ++i) {
			clock.PlusOneSecond();
		}
	}
}