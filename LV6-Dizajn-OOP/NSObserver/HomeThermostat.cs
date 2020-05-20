using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LV6_Dizajn_OOP.NSObserver
{
    public class HomeThermostat : WeatherObserver
    {
        bool HeatingIsOn = false;
        bool CoolingIsOn = true;
        const int HeatingThreshold = 15;
        const int CoolingThreshold = 25;
        public void Update(int temperature)
        {
            if (temperature < HeatingThreshold) { StartHeating(); }
            else if (temperature > CoolingThreshold) { StartCooling(); }
            else { StopAll(); }
        }
        private void StartHeating()
        {
            Console.WriteLine("Now heating"); HeatingIsOn = true; CoolingIsOn = false;
        }
        private void StartCooling()
        {
            Console.WriteLine("Now cooling.");
        }
        private void StopAll()
        {
            Console.WriteLine("Stopping all");
        }
    }
}