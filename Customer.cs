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
        double MaxPrice;
     // constructor
     public Customer()
     {
            LemonFlavorModifier = -30;
             SweetToothModifier = 20;
            CoolnessModifier = 25;
             PriceModifier = 50;
            ChanceToBuy = GenerateChanceToBuy();
            MaxPrice = GetMaxPrice();

     }

     // member methods (CAN DO)
     public double GenerateChanceToBuy()
        {
            Random rnd = new Random();
            double  ChanceToBuy = rnd.Next(0, 101);
            return ChanceToBuy;
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
     public double SweetnessModifier(double lemon, double sugar, double ActualTemperature)
        {
            double SweetToothDeviation = 10;
            if ( 2 < sugar && (lemon - sugar) <= 3 && lemon < 8 && ActualTemperature > 80)
            {
                return SweetToothModifier;
            }
            else if (5 < sugar && (lemon - sugar) <= 4 && lemon > 9 && ActualTemperature < 70)
            {
                return SweetToothModifier;
            }
            else if (2 < sugar && (lemon - sugar) <= 4)
            {
                return SweetToothModifier -= SweetToothDeviation;
            }
            else if( (lemon - sugar) > 4)
            {
                return LemonFlavorModifier;
            }
            else
            {
                return -SweetToothModifier;
            }
        }
        public double GetMaxPrice()
        {
            Random rnd = new Random();
            double MaxPrice = rnd.Next(15, 41);
            return MaxPrice;
        }
        public double MaxPriceModifier(double Maxprice, double price)
        {
            if (Maxprice > price)
            {
                return PriceModifier;
            }
            else
            {
                return -PriceModifier;
            }
        }
        public double IceModifier( double icecubes, double temperature)
        { double IcePerCupHotDay = 8;
            double IcePerCupWarmDay = 6;

            if (icecubes > IcePerCupHotDay && 10 >= icecubes && temperature > 85)
            {
                return CoolnessModifier;
            }
            else if (icecubes > IcePerCupWarmDay && 8 >= icecubes && temperature > 70)
            {
                return CoolnessModifier;
            }
            else if ( 6 > icecubes && temperature > 70)
            {
                return -CoolnessModifier;
            }
            else
            {
                return 0;
            }

        }
    }
}
