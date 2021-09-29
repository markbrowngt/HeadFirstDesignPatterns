using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        public decimal HeatIndex { get; set; } = 0.0m;
        
        public HeatIndexDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);   
        }

        public void Display()
        {
            Console.WriteLine($"Heat index is {HeatIndex}.");
        }

        private decimal ComputeHeatIndex(decimal temp, decimal humidity)
        {
            return ((16.923m + (0.185212m * temp) + (5.37941m * humidity) - (0.100254m * temp * humidity) 
			+ (0.00941695m * (temp * temp)) + (0.00728898m * (humidity * humidity)) 
			+ (0.000345372m * (temp * temp * humidity)) - (0.000814971m * (temp * humidity * humidity)) +
			(0.0000102102m * (temp * temp * humidity * humidity)) - (0.000038646m * (temp * temp * temp)) + (0.0000291583m * 
			(humidity * humidity * humidity)) + (0.00000142721m * (temp * temp * temp * humidity)) + 
			(0.000000197483m * (temp * humidity * humidity * humidity)) - (0.0000000218429m * (temp * temp * temp * humidity * humidity)) +
			0.000000000843296m * (temp * temp * humidity * humidity * humidity)) -
			(0.0000000000481975m * (temp * temp * temp * humidity * humidity * humidity)));
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            HeatIndex = ComputeHeatIndex(temp, humidity);
            Display();
        }
    }
}