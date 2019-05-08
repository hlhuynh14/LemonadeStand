using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {// member variables (HAS A)
     public double TimeOfDay;
        public Weather weather;


     // constructor
        
     public Day()
     { TimeOfDay = 9;
            Weather weather = new Weather();

        }

     // member methods (CAN DO)
     public double AddHour(double TimeOfDay)
     {
       TimeOfDay = TimeOfDay + 1;
            return TimeOfDay;
     }
        public void ShowWeather()
        {
            double NewTemperatureForecast = weather.ForecastTemperature;
            string NewForecast = weather.forecast;
            UserInterface.DisplayWeatherForecast(NewTemperatureForecast, NewForecast);
        }
        public void ShowActualWeather()
        {
            double NewTemperatureForecast = weather.GenerateActualTemperature(weather.ForecastTemperature);
            string NewForecast = weather.GenerateActualWeather(weather.forecast);
            UserInterface.DisplayWeatherForecast(NewTemperatureForecast, NewForecast);
        }
    }
}


