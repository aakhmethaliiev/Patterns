﻿namespace WeatherApp.Observer
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}