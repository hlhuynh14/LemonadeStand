using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // member variables (HAS A)
        // currently not using this but keeping around for use in later version
        private double timeOfDay;
        public Weather weather;
       
       

         // constructor
        
         public Day()
         {
                timeOfDay = 9;
                weather = new Weather();
           

            }

         // member methods (CAN DO)
         private double AddHour(double timeOfDay)
         {
                timeOfDay = timeOfDay + 1;
                return timeOfDay;
         }
        public void ShowWeather()
        {
            int newTemperatureForecast = weather.forecastTemperature;
            string newForecast = weather.forecast;
            UserInterface.DisplayWeatherForecast(Program.temperatureDescription, Program.weatherDescription);
        }
        public void ShowActualWeather()
        {
            double newTemperatureForecast = weather.actualTemperature;
            string newForecast = weather.actualForecast;
            UserInterface.DisplayActualWeatherForecast(Program.temperatureDescription, Program.weatherDescription);
        }
    }
}







