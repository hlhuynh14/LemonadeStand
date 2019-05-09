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
        public double pitcher;
        // constructor
        public Game()
        {
            Player1 = new Human();
            GameStore = new Store();
            pitcher = 32;

        }
        // member methods (CAN DO)
        public void StartGame()
        {
            for (int i = 0; i < 8; i++)
            {
                double StartingCash = Player1.cash;
                Day day = new Day();
                day.ShowWeather();
                UserInterface.CheckInventory(Player1.PlayerInventory.inventory[0], Player1.PlayerInventory.inventory[1], Player1.PlayerInventory.inventory[2], Player1.PlayerInventory.inventory[3]);
                UserInterface.GoToStore(GameStore, Player1);
                UserInterface.CheckInventory(Player1.PlayerInventory.inventory[0], Player1.PlayerInventory.inventory[1], Player1.PlayerInventory.inventory[2], Player1.PlayerInventory.inventory[3]);
                double CashUsed = Player1.cash;
                double ActualCustomer = 0;
                day.ShowActualWeather();

                double MaxCustomer = GenerateCustomerMaxValue(day.weather.ForecastTemperature, day.weather.forecast);
                for (int j = 0; j < MaxCustomer; j++)
                {
                    if (Player1.PlayerInventory.inventory[1] < Player1.PlayerRecipe.recipe[0] || Player1.PlayerInventory.inventory[2] < Player1.PlayerRecipe.recipe[1])
                    {
                        Console.WriteLine("You dont have enough ingredients.");
                        break;
                    }
                    Customer customer = new Customer();
                    double Maxprice = customer.GetMaxPrice();
                    double ChanceToBuy = customer.GenerateChanceToBuy();
                    double WeatherModifier = customer.GetWeatherModifier(day.weather.GenerateActualWeather(day.weather.forecast), day.weather.GenerateActualTemperature(day.weather.ForecastTemperature));
                    double SweetnessModifier = customer.SweetnessModifier(Player1.PlayerRecipe.recipe[0], Player1.PlayerRecipe.recipe[1], day.weather.GenerateActualTemperature(day.weather.ForecastTemperature));
                    double MaxPriceModifier = customer.MaxPriceModifier(Maxprice, Player1.PlayerRecipe.recipe[3]);
                    double IceModifier = customer.IceModifier(Player1.PlayerRecipe.recipe[3], day.weather.GenerateActualTemperature(day.weather.ForecastTemperature));
                    ChanceToBuy = ChanceToBuy + WeatherModifier + SweetnessModifier + MaxPriceModifier + IceModifier;
                    if (BuyIt(ChanceToBuy) == true)
                    {
                        Player1.AddMoney(Player1.PlayerRecipe.recipe[3]);
                        UserInterface.DisplayCash(Player1);
                        pitcher--;
                        Player1.PlayerInventory.inventory[0]--;
                        Player1.PlayerInventory.inventory[3] -= Player1.PlayerRecipe.recipe[2];
                        ActualCustomer++;

                    }
                    if (Player1.PlayerInventory.inventory[0] == 0)
                    {
                        Console.WriteLine("You dont have enough cups.");
                        break;
                    }
                    if (pitcher == 0)
                    {
                        NewPitcher(Player1);
                        pitcher = 32;
                    }
                    if (Player1.PlayerInventory.inventory[1] < Player1.PlayerRecipe.recipe[0] || Player1.PlayerInventory.inventory[2] < Player1.PlayerRecipe.recipe[1] || Player1.PlayerInventory.inventory[3] < Player1.PlayerRecipe.recipe[2])
                    {
                        Console.WriteLine("You dont have enough ingredients.");
                        break;
                    }
                }
                UserInterface.DisplayProfit(StartingCash, Player1.cash);
                UserInterface.DisplayTotalProfit(CashUsed, Player1.cash);
                UserInterface.GetCustomers(MaxCustomer, ActualCustomer);
            }

            UserInterface.EndgameNotice(Player1, 20);
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
        public void NewPitcher(Player player)
        {
            player.PlayerInventory.inventory[1] -= player.PlayerRecipe.recipe[0];
                player.PlayerInventory.inventory[2] -= player.PlayerRecipe.recipe[1];
        }
    }
}
