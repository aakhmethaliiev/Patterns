using WeatherApp.Observer;

namespace WeatherApp.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserves();
    }
}