using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {// member variables (HAS A)
        double LemonFlavorModifier;
        double SweetToothModifier;
        double CoolnessModifier;
        double PriceModifier;
        double ChanceToBuy;
     // constructor
     public Customer()
     {
            LemonFlavorModifier = -10;
             SweetToothModifier = 20;
            CoolnessModifier = 15;
             PriceModifier = -15;
             ChanceToBuy = 35;

     }

     // member methods (CAN DO)
     public double CheckTemp(double temperature)
     {
            return temperature;
     }
     public string CheckForecast( string forecast)
     {
            return forecast;
     }
     public double GetWeatherModifier(string ActualWeather, double ActualTemperature)
     {
            if (ActualWeather == "Sunny" && ActualTemperature >= 80)
            {
                return 20;
            }
            else if (ActualWeather == "Cloudy" && ActualTemperature >= 80)
            {
                return 15;
            }
            else if (ActualWeather == "Rainy" && ActualTemperature >= 80)
            {
                return 10;
            }
            else if (ActualWeather == "Sunny" && ActualTemperature > 65)
            {
                return 10;
            }
            else if (ActualWeather == "Cloudy" && ActualTemperature > 65)
            {
                return 5;
            }
            else if (ActualWeather == "Rainy" && ActualTemperature > 65)
            {
                return 0;
            }
            else if (ActualWeather == "Sunny" && ActualTemperature > 58)
            {
                return -5;
            }
            else if (ActualWeather == "Cloudy" && ActualTemperature > 58)
            {
                return -10;
            }
            else 
            {
                return -20;
            }
     }
     public void SweetnessModifier(double lemon, double sugar)
        {
            if ( 0 < (lemon - sugar) && (lemon - sugar) < 3)
            {

            }

        }

    }
}
