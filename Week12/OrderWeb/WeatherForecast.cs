namespace OrderWeb;

public class WeatherForecast {
	public DateTime Date { get; set; }

	public int TemperatureC { get; set; }

	public int TemperatureF => 32 + (int)(this.TemperatureC / (5.0 / 9.0));

	public string? Summary { get; set; }
}