namespace TennisBookings.Shared.Weather;

public class AmazingWeatherForecaster
{
	public Task<WeatherResult> GetCurrentWeatherAsync(string city)
	{
		// DO Something amazing here

		return Task.FromResult(
			new WeatherResult() { City = city, Weather = new WeatherCondition() { Summary = "Sun" } });
	}
}
