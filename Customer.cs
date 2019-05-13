using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {// member variables (HAS A)
        double lemonFlavorModifier;
        double sweetToothModifier;
        double coolnessModifier;
        double priceModifier;
        double chanceToBuy;
        double maxPrice;


     // constructor
     public Customer()
     {
            lemonFlavorModifier = -30;
             sweetToothModifier = 20;
            coolnessModifier = 50;
             priceModifier = 50;
            chanceToBuy = GenerateChanceToBuy();
            maxPrice = GetMaxPrice();

     }

     // member methods (CAN DO)
     protected double GenerateChanceToBuy()
        {
            Random rnd = new Random();
            double  chanceToBuy = rnd.Next(0, 22);
            return chanceToBuy;
        }
     protected double GetWeatherModifier(string actualWeather, double actualTemperature)
     {
            if (Program.weatherDescription == "clear sky" && Program.temperatureDescription >= 80)
            {
                return 20;
            }
            else if (Program.weatherDescription == " few cloud" && Program.temperatureDescription >= 80)
            {
                return 15;
            }
            else if (Program.weatherDescription == "rain" && Program.temperatureDescription >= 80)
            {
                return 10;
            }
            else if (Program.weatherDescription == "clear sky" && Program.temperatureDescription > 65)
            {
                return 10;
            }
            else if (Program.weatherDescription == "few cloud" && Program.temperatureDescription > 65)
            {
                return 5;
            }
            else if (Program.weatherDescription == "rain" && Program.temperatureDescription > 65)
            {
                return 0;
            }
            else if (Program.weatherDescription == "clear sky" && Program.temperatureDescription > 58)
            {
                return -5;
            }
            else if (Program.weatherDescription == "few cloud" && Program.temperatureDescription > 58)
            {
                return -10;
            }
            else 
            {
                return -20;
            }
     }
     protected double SweetnessModifier(double lemon, double sugar, double actualTemperature)
        {
            double sweetToothDeviation = 10;
            if ( 2 < sugar && (lemon - sugar) <= 3 && lemon < 8 && actualTemperature > 80)
            {
                return sweetToothModifier;
            }
            else if (5 < sugar && (lemon - sugar) <= 4 && lemon > 9 && actualTemperature < 70)
            {
                return sweetToothModifier;
            }
            else if (2 < sugar && (lemon - sugar) <= 4)
            {
                return sweetToothModifier -= sweetToothDeviation;
            }
            else if( (lemon - sugar) > 4)
            {
                return lemonFlavorModifier;
            }
            else
            {
                return -sweetToothModifier;
            }
        }
        protected double GetMaxPrice()
        {
            Random rnd = new Random();
            double maxPrice = rnd.Next(20, 41);
            return maxPrice;
        }
        protected double MaxPriceModifier(double maxprice, double price)
        {
            if (maxprice > price)
            {
                return priceModifier;
            }
            else
            {
                return -priceModifier;
            }
        }
        protected double IceModifier( double icecubes, double temperature)
        { double icePerCupHotDay = 8;
            double icePerCupWarmDay = 6;

            if (icecubes > icePerCupHotDay && temperature > 85)
            {
                return coolnessModifier;
            }
            else if (icecubes > icePerCupWarmDay && temperature > 70)
            {
                return coolnessModifier;
            }
            else if (icePerCupWarmDay > icecubes && temperature > 70)
            {
                return -coolnessModifier;
            }
            else if (icecubes > 3 && temperature < 70)
            {
                return -coolnessModifier;
            }
            else
            {
                return 0;
            }

        }

        public double TotalChanceToBuy(string forecast, int temperature, double lemons, double sugar, double icecubes, double price)
        {
            double maxprice = GetMaxPrice();
            double chanceToBuy = GenerateChanceToBuy();
            double weatherModifier = GetWeatherModifier(forecast, temperature);
            double sweetModifier = SweetnessModifier(lemons, sugar, temperature);
            double maxPriceModifier = MaxPriceModifier(maxprice, price);
            double iceModifier = IceModifier(icecubes, temperature);
            chanceToBuy = chanceToBuy + weatherModifier + sweetModifier + maxPriceModifier + iceModifier;
            //Console.WriteLine(chanceToBuy); customer bug test.
            return chanceToBuy;
        }
    }
}
