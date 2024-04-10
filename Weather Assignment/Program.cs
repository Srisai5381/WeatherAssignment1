
namespace WeatherMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create WeatherData instance
            WeatherData weatherData = WeatherData.Instance;

            // Create different displays 
            CurrentConditionsDisplay currentConditionsDisplay = WeatherStation.CreateCurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = WeatherStation.CreateStatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = WeatherStation.CreateForecastDisplay(weatherData);

            // Simulate weather data changes
            weatherData.MeasurementsChanged();
        }
    }
}
