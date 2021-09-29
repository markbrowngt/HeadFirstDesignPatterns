using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        public List<decimal> Temperatures { get; set; }
        
        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);   
            Temperatures = new();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature: {Temperatures.Average()}/{Temperatures.Max()}/{Temperatures.Min()}.");
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            Temperatures.Add(temp);
            Display();
        }
    }
}