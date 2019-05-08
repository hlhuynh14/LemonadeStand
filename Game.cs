using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {// member variables (HAS A)
        public Human Player1;
        public Store GameStore;
        // constructor
        public Game()
        {
            Player1 = new Human();
            GameStore = new Store();

        }
        // member methods (CAN DO)
        public void StartGame()
        {

            Day day = new Day();
            day.ShowWeather();
            UserInterface.CheckInventory(Player1.PlayerInventory.inventory[0], Player1.PlayerInventory.inventory[1], Player1.PlayerInventory.inventory[2], Player1.PlayerInventory.inventory[3]);
            UserInterface.GoToStore(GameStore, Player1);
            UserInterface.CheckInventory(Player1.PlayerInventory.inventory[0], Player1.PlayerInventory.inventory[1], Player1.PlayerInventory.inventory[2], Player1.PlayerInventory.inventory[3]);


            double MaxCustomer = GenerateCustomerMaxValue(day.weather.ForecastTemperature, day.weather.forecast);
            for (int i = 0; i < MaxCustomer; i++)
            {
                Customer customer = new Customer();
                double Maxprice = customer.GetMaxPrice();
                double ChanceToBuy = customer.GenerateChanceToBuy();
                double WeatherModifier = customer.GetWeatherModifier(day.weather.GenerateActualWeather(day.weather.forecast), day.weather.GenerateActualTemperature(day.weather.ForecastTemperature));
                double SweetnessModifier = customer.SweetnessModifier(Player1.PlayerRecipe.recipe[0], Player1.PlayerRecipe.recipe[1], day.weather.GenerateActualTemperature(day.weather.ForecastTemperature));
                double MaxPriceModifier = customer.MaxPriceModifier(Maxprice, Player1.PlayerRecipe.recipe[3]);
                double IceModifier = customer.IceModifier(Player1.PlayerRecipe.recipe[3], day.weather.GenerateActualTemperature(day.weather.ForecastTemperature));
                ChanceToBuy = ChanceToBuy + WeatherModifier + SweetnessModifier + MaxPriceModifier + IceModifier;
                if ( BuyIt(ChanceToBuy) == true)
                {

                }
                    
                    
                    
            }
            

                    

        }
        public bool BuyIt( double ChancetoBuy)
        {
            if (ChancetoBuy > 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GenerateCustomerMaxValue(int temperature, string forecast)
        {
            if (temperature > 80 && forecast == "Sunny")
            {
                return 100;
            }
            else if (temperature > 60 && forecast == "Sunny")
            {
                return 70;
            }
            if (temperature > 80 && forecast == "Cloudy")
            {
                return 95;
            }
            else if (temperature > 60 && forecast == "Cloudy")
            {
                return 65;
            }
            if (temperature > 80 && forecast == "Rainy")
            {
                return 85;
            }
            else if (temperature > 60 && forecast == "rainy")
            {
                return 60;
            }
            else
            {
                return 50;
            }


        }
    }
}
