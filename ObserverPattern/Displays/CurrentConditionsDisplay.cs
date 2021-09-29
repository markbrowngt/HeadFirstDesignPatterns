using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        
        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);   
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {Temperature}F degrees and {Humidity}% humidity.");
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Display();
        }
    }
}