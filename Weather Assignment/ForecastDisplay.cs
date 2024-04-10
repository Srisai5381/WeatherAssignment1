
namespace WeatherMonitoringSystem
{
    /// <summary>
    /// It displays a weather forecast based on the current weather data
    /// </summary>

    public class ForecastDisplay : IDisplay
    {
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this); 
        }

        // Update weather forecast
        public void Update(double temp, double humid)
        {
            // Adjust the forecast based on the temperature conditions. As a rule of thumb, consider it sunny if the temperature is above 25°C, and rainy if it is not.
            string forecast = temp > 25 ? "Sunny" : "Rainy";

            Display(forecast); 
        }

        // Display weather forecast
        public void Display()
        {
            
        }

        // Overloaded Display method to accept forecast data
        public void Display(string forecast)
        {
            Console.WriteLine($"Weather Forecast: {forecast}");
        }
    }
}
