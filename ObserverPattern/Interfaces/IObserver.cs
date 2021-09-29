namespace ObserverPattern
{
    public interface IObserver
    {
        public void Update(decimal temp, decimal humidity, decimal pressure);
    }
}