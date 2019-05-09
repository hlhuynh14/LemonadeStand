using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {// member variables (HAS A)
        
        private Human player1;
        private Store gameStore;
        private double pitcher;
        // constructor
        public Game()
        {
            player1 = new Human();
            gameStore = new Store();
            pitcher = 32;

        }
        // member methods (CAN DO)
        public void StartGame()
        {
            
            UserInterface.ShowRules();
            double gameDays = UserInterface.AskGameDays();
            for (int i = 1; i <= gameDays; i++)
            {
                double startingCash = player1.cash;
                Day day = new Day();
                day.ShowWeather();
                UserInterface.CheckInventory(player1.playerInventory.numberOfCups, player1.playerInventory.numberOfLemons, player1.playerInventory.numberOfSugar, player1.playerInventory.numberOfIcecubes);
                UserInterface.GoToStore(gameStore, player1);
                UserInterface.CheckInventory(player1.playerInventory.numberOfCups, player1.playerInventory.numberOfLemons, player1.playerInventory.numberOfSugar, player1.playerInventory.numberOfIcecubes);
                UserInterface.ShowRecipe(player1.playerRecipe.lemonRecipeNumber, player1.playerRecipe.sugarRecipeNumber, player1.playerRecipe.icecubeRecipeNumber, player1.playerRecipe.priceRecipeNumber);
                UserInterface.AlterRecipe(player1);
                NewPitcher(player1);
                double cashUsed = player1.cash;
                double actualCustomer = 0;
                day.ShowActualWeather();

                double maxCustomer = GenerateCustomerMaxValue(day.weather.forecastTemperature, day.weather.forecast);
                for (int j = 0; j < maxCustomer; j++)
                {
                    if (player1.playerInventory.numberOfLemons < player1.playerRecipe.lemonRecipeNumber || player1.playerInventory.numberOfSugar < player1.playerRecipe.sugarRecipeNumber || player1.playerInventory.numberOfIcecubes < player1.playerRecipe.icecubeRecipeNumber || player1.playerInventory.numberOfCups < 1)
                    {
                        Console.WriteLine("You dont have enough ingredients.");
                        break;
                    }
                    Customer customer = new Customer();

                    if (BuyIt(customer.TotalChanceToBuy(day.weather.actualForecast, day.weather.actualTemperature, player1.playerRecipe.lemonRecipeNumber, player1.playerRecipe.sugarRecipeNumber, player1.playerRecipe.icecubeRecipeNumber, player1.playerRecipe.priceRecipeNumber)))
                    {
                        player1.AddMoney(player1.playerRecipe.priceRecipeNumber);
                        UserInterface.DisplayCash(player1);
                        pitcher--;
                        player1.playerInventory.numberOfCups--;
                        player1.playerInventory.numberOfIcecubes -= player1.playerRecipe.icecubeRecipeNumber;
                        actualCustomer++;

                    }
                    if (player1.playerInventory.numberOfCups == 0)
                    {
                        Console.WriteLine("You dont have enough cups.");
                        break;
                    }
                    if (pitcher == 0)
                    {
                        NewPitcher(player1);
                        pitcher = 32;
                    }
                    if (player1.playerInventory.numberOfLemons < player1.playerRecipe.lemonRecipeNumber || player1.playerInventory.numberOfSugar < player1.playerRecipe.sugarRecipeNumber || player1.playerInventory.numberOfIcecubes < player1.playerRecipe.icecubeRecipeNumber)
                    {
                        Console.WriteLine("You dont have enough ingredients.");
                        break;
                    }


                }
                UserInterface.DisplayProfit(startingCash, player1.cash);
                UserInterface.DisplayTotalProfit(cashUsed, player1.cash);
                UserInterface.GetCustomers(maxCustomer, actualCustomer);
            }

            UserInterface.EndgameNotice(player1, 20);
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
            player.playerInventory.numberOfLemons -= player.playerRecipe.lemonRecipeNumber;
            player.playerInventory.numberOfSugar -= player.playerRecipe.sugarRecipeNumber;
        }

        public bool BuyIt( double chanceTobuy)
        {
            if (chanceTobuy > 65)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}







                  
// customer.SetModifiers(day.weather);




