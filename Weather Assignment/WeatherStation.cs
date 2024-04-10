// WeatherStation.cs
namespace WeatherMonitoringSystem
{
    /// <summary>
    /// This is a factory for creating different types of displays.
    /// </summary>
    public static class WeatherStation
    {
        // Create and return CurrentConditionsDisplay
        public static CurrentConditionsDisplay CreateCurrentConditionsDisplay(WeatherData weatherData)
        {
            return new CurrentConditionsDisplay(weatherData);
        }

        // Create and return StatisticsDisplay
        public static StatisticsDisplay CreateStatisticsDisplay(WeatherData weatherData)
        {
            return new StatisticsDisplay(weatherData);
        }

        // Create and return ForecastDisplay
        public static ForecastDisplay CreateForecastDisplay(WeatherData weatherData)
        {
            return new ForecastDisplay(weatherData);
        }
    }
}
