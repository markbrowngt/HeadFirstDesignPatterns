using System;
using System.Text;

namespace ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData _weatherData;
        public decimal CurrentPressure { get; set; }
        public decimal LastPressure { get; set; }
        
        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);   
        }

        private string ForecastText()
        {
            StringBuilder sb = new();

            if (CurrentPressure > LastPressure)
            {
                sb.Append("Improving weather on the way!");
            } 
            else if (CurrentPressure == LastPressure)
            {
                sb.Append("More of the same.");
            }
            else if (CurrentPressure < LastPressure)
            {
                sb.Append("Watch out for cooler, rainy weather.");
            }

            return sb.ToString();
        }

        public void Display()
        {
            Console.WriteLine($"Forecast: {ForecastText()}");
        }

        public void Update(decimal temp, decimal humidity, decimal pressure)
        {
            LastPressure = CurrentPressure;
            CurrentPressure = pressure;
            Display();
        }
    }
}