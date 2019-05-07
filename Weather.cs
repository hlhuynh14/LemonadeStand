using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {// member variables (HAS A)
        double temperature;
        string forecast;

        // constructor
        public Weather()
        {
            temperature = GenerateTemperature();
            forecast = GenerateForecast();
        }

        // member methods (CAN DO)
        public double GenerateTemperature()
        { Random rnd = new Random();
            double TemperatureChance = rnd.Next(59, 106);
            return TemperatureChance;

        }

        public string GenerateForecast()
        {
            Random rnd = new Random();
            double WeatherChance = rnd.Next(1, 4);
            
            if (WeatherChance == 1)
            {
                return "Rain";
            }
            else if (WeatherChance == 2)
            {
                return "Sunny";
            }
            else
            {
                return "Cloudy";
            }

        }
    }
}
