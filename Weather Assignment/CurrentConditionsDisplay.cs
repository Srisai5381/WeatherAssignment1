
namespace WeatherMonitoringSystem
{
    /// <summary>
    /// This is one of the observers. It displays the current weather conditions. It’s also a decorator that can add additional information (like date and time) to the display
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        private int temp;
        private int humid;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Attach(this); 
        }

        // Change weather conditions
        public void Update(int temp, int humid)
        {
            this.temp = temp;
            this.humid = humid;
            Display(); 
        }

        // Display present weather conditions
        public void Display()
        {
            Console.WriteLine($"Present Conditions: {temp}°C and {humid}% humidity");
       
        }
    }
}
