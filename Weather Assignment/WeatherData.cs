
namespace WeatherMonitoringSystem
{
    /// <summary>
    ///A singleton class tasked with aggregating weather data and informing observers
    /// </summary>
    public sealed class WeatherData
    {
        private static readonly WeatherData instance = new WeatherData();
        private List<IDisplay> observers;
        private Random random;

        // Singleton instance
        public static WeatherData Instance
        {
            get { return instance; }
        }

        private WeatherData()
        {
            observers = new List<IDisplay>();
            random = new Random();
        }

        // Attach an observer
        public void Attach(IDisplay observer)
        {
            observers.Add(observer);
        }

        // Detach an observer
        public void Detach(IDisplay observer)
        {
            observers.Remove(observer);
        }

        // Inform all observers upon any change in weather data
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Display();
            }
        }

        // Simulate weather data change (for explanation)
        public void MeasurementsChanged()
        {
            // Generate random weather data
            int temp = random.Next(0, 40);
            int humid = random.Next(0, 100);
            int pressure = random.Next(980, 1050);

            // Update weather data
            SetMeasurements(temp, humid, pressure);
        }

        // Set weather data
        public void SetMeasurements(int temp, int humid, int pressure)
        {
            // Set weather data here
            // just printing the data
            Console.WriteLine($"Weather Data Updated: Temperature = {temp}, Humidity = {humid}, Pressure = {pressure}");
            // Notify observers
            NotifyObservers();
        }
    }
}
