
namespace WeatherMonitoringSystem
{
    /// <summary>
    /// // A specific observer designed to present weather statistics.
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        private int maxTemp = int.MinValue;
        private int minTemp = int.MaxValue;   
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this); 
        }

        // Update statistics
        public void Update(int temp)
        {
            // Update statistics based on temperature
            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display(); 
        }

        // Display weather statistics
        public void Display()
        {
            Console.WriteLine($"Max Temp: {maxTemp}°C");
            Console.WriteLine($"Min Temp: {minTemp}°C");
        }
    }
}
