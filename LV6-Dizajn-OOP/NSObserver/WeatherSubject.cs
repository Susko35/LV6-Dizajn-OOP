using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.NSObserver
{
    public interface WeatherSubject
    {
        void AddObserver(WeatherObserver weatherObserver);
        void RemoveObserver(WeatherObserver weatherObserver);
        void Notify();
    }
}
