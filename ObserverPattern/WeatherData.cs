using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        public List<IObserver> Observers { get; set; }

        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal Pressure { get; set; }

        public WeatherData()
        {
            Observers = new();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach(var o in Observers)
            {
                o.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void SetMeasurements(decimal temperature, decimal humidity, decimal pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}