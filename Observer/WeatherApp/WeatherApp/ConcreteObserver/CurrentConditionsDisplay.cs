using System;
using WeatherApp.Display;
using WeatherApp.Observer;
using WeatherApp.Subject;

namespace WeatherApp.ConcreteObserver
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature} *C; {_humidity} % humidity");
        }
    }
}