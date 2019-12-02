using System;
using WeatherApp.ConcreteObserver;
using WeatherApp.Subject;

namespace WeatherApp
{
    internal class Program
    {
        private static void Main()
        {
            var weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(20, 65, 30.4f);
            weatherData.SetMeasurements(18, 70, 29.4f);
            weatherData.SetMeasurements(15, 75, 28.4f);

            Console.ReadKey();
        }
    }
}
