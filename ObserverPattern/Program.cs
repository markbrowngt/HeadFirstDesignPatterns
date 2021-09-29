using System;
using System.IO;
using System.Text;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new();

            CurrentConditionsDisplay currentDisplay = new(weatherData);
            StatisticsDisplay statisticsDisplay = new(weatherData);
            ForecastDisplay forecastDisplay = new(weatherData);
            HeatIndexDisplay heatIndexDisplay = new(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4m);
            weatherData.SetMeasurements(82, 70, 29.2m);
            weatherData.SetMeasurements(78, 90, 29.2m);
        }
    }
}
