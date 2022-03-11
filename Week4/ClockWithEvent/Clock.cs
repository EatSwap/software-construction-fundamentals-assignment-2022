namespace ClockWithEvent;

public class TickArgs {
	public int Hour { get; set; }
	public int Minute { get; set; }
	public int Second { get; set; }

	public TickArgs(int hour = 0, int minute = 0, int second = 0) {
		Hour = hour;
		Minute = minute;
		Second = second;
	}
}

public delegate void TickHandler(object sender, TickArgs e);

public delegate void AlarmHandler(object sender);

public class Clock {
	private int hour, minute, second;

	private int alarmHour, alarmMinute, alarmSecond;
	
	public event TickHandler Tick;

	public event AlarmHandler Alarm;

	private void CheckRangeAndSet(int val, int limit, ref int target) {
		if (val >= limit || val < 0)
			throw new ArgumentOutOfRangeException(nameof(val), val, "Value must be less than " + limit);
		target = val;
	}

	public int Hour {
		get => hour;
		set => CheckRangeAndSet(value, 24, ref hour);
	}

	public int Minute {
		get => minute;
		set => CheckRangeAndSet(value, 60, ref minute);
	}

	public int Second {
		get => second;
		set => CheckRangeAndSet(value, 60, ref second);
	}

	public int AlarmHour {
		get => alarmHour;
		set => CheckRangeAndSet(value, 24, ref alarmHour);
	}
	
	public int AlarmMinute {
		get => alarmMinute;
		set => CheckRangeAndSet(value, 60, ref alarmMinute);
	}
	
	public int AlarmSecond {
		get => alarmSecond;
		set => CheckRangeAndSet(value, 60, ref alarmSecond);
	}
	
	public Clock(int h, int m, int s) {
		Hour = h;
		Minute = m;
		Second = s;
		AlarmHour = AlarmMinute = AlarmSecond = 0;
	}

	public void SetAlarm(int h, int m, int s) {
		AlarmHour = h;
		AlarmMinute = m;
		AlarmSecond = s;
	}
	
	public void PlusOneSecond() {
		second = (1 + second) % 60;
		minute = second == 0 ? (1 + minute) % 60 : minute;
		hour = minute == 0 && second == 0 ? (1 + hour) % 60 : hour;
		Tick(this, new TickArgs(hour, minute, second));
		if (second == alarmSecond && minute == alarmMinute && hour == alarmHour)
			Alarm(this);
	}
}

