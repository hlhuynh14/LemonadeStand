using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {// member variables (HAS A)
        public int forecastTemperature;
        public string forecast;
        public int actualTemperature;
        public string actualForecast;

        // constructor
        public Weather()
        {
            forecastTemperature = GenerateForecastTemperature();
            forecast = GenerateForecast();
            actualTemperature = GenerateActualTemperature(forecastTemperature);
            actualForecast = GenerateActualWeather(forecast);

        }

        // member methods (CAN DO)
        private int GenerateForecastTemperature()
        {
            int maxWeatherRange = 106;
            int minWeatherRange = 59;
            

            Random rnd = new Random();
            int temperatureChance = rnd.Next(minWeatherRange, maxWeatherRange);
            return temperatureChance;

        }
        private int GenerateActualTemperature( int forecastTemperature)
        { int weatherDeviation = 5;
            Random rnd = new Random();
            int actualTemperatureChance = rnd.Next((forecastTemperature - weatherDeviation), (forecastTemperature + weatherDeviation));
            return actualTemperatureChance;
        }

        private string GenerateForecast()
        {
            Random rnd = new Random();
            double weatherChance = rnd.Next(1, 4);
            
            if (weatherChance == 1)
            {
                return "Rain";
            }
            else if (weatherChance == 2)
            {
                return "Sunny";
            }
            else
            {
                return "Cloudy";
            }

        }
        private string GenerateActualWeather( string forecast)
        {
            if (forecast == "Rain")
            {
                Random rnd = new Random();
                double weatherChanceRain = rnd.Next(1, 3);
                if (weatherChanceRain == 2)
                {
                    return "Rain";
                }
                else
                {
                    return "Cloudy";
                }

            }
            else if (forecast == "Sunny")
            {
                Random rnd = new Random();
                double weatherChanceSunny = rnd.Next(1, 3);
                if (weatherChanceSunny == 2)
                {
                    return "Sunny";
                }
                else
                {
                    return "Cloudy";
                }
            }
            else
            {
                Random rnd = new Random();
                double weatherChanceCloudy = rnd.Next(1, 4);
                if (weatherChanceCloudy == 3)
                {
                    return "Cloudy";
                }
                else if (weatherChanceCloudy == 2)
                {
                    return "Sunny";
                }
                else
                {
                    return "Rainy";
                }

            }
        }
    }
}
