using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {// member variables (HAS A)
        double ForecastTemperature;
        string forecast;

        // constructor
        public Weather()
        {
            ForecastTemperature = GenerateForecastTemperature();
            forecast = GenerateForecast();
        }

        // member methods (CAN DO)
        public double GenerateForecastTemperature()
        {
            int MaxWeatherRange = 106;
            int MinWeatherRange = 59;

            Random rnd = new Random();
            int TemperatureChance = rnd.Next(MinWeatherRange, MaxWeatherRange);
            return TemperatureChance;

        }
        public double GenerateActualTemperature( int ForecastTemperature)
        { int WeatherDeviation = 10;
            Random rnd = new Random();
            int ActualTemperatureChance = rnd.Next((ForecastTemperature - WeatherDeviation), (ForecastTemperature + WeatherDeviation);
            return ActualTemperatureChance;
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
        public string GenerateActualWeather( string forecast)
        {
            if (forecast == "Rain")
            {
                Random rnd = new Random();
                double WeatherChanceRain = rnd.Next(1, 3);
                if (WeatherChanceRain == 2)
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
                double WeatherChanceSunny = rnd.Next(1, 3);
                if (WeatherChanceSunny == 2)
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
                double WeatherChanceCloudy = rnd.Next(1, 4);
                if (WeatherChanceCloudy == 3)
                {
                    return "Cloudy";
                }
                else if (WeatherChanceCloudy == 2)
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
