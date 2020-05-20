using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Dizajn_OOP.NSObserver
{
    public interface WeatherObserver
    {
        void Update(int temperature);
    }
}
