using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {// member variables (HAS A)
        
        Human player1;
        Store gameStore;
        double pitcher;
        Day day;
        double actualCustomer;
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
            GameDaysLoop(gameDays);
            UserInterface.EndgameNotice(player1, 20);
        }

        private double GenerateCustomerMaxValue(int temperature, string forecast)
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
        private void NewPitcher(Player player)
        {
            player.playerInventory.numberOfLemons -= player.playerRecipe.lemonRecipeNumber;
            player.playerInventory.numberOfSugar -= player.playerRecipe.sugarRecipeNumber;
        }

        private bool BuyIt( double chanceTobuy)
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
        private void DoPreparation()
        {
            day = new Day();
            day.ShowWeather();
            UserInterface.CheckInventory(player1.playerInventory.numberOfCups, player1.playerInventory.numberOfLemons, player1.playerInventory.numberOfSugar, player1.playerInventory.numberOfIcecubes);
            UserInterface.GoToStore(gameStore, player1);
            UserInterface.CheckInventory(player1.playerInventory.numberOfCups, player1.playerInventory.numberOfLemons, player1.playerInventory.numberOfSugar, player1.playerInventory.numberOfIcecubes);
            UserInterface.ShowRecipe(player1.playerRecipe.lemonRecipeNumber, player1.playerRecipe.sugarRecipeNumber, player1.playerRecipe.icecubeRecipeNumber, player1.playerRecipe.priceRecipeNumber);
            UserInterface.AlterRecipe(player1);
            NewPitcher(player1);
        }
        private void GetCustomerIfStatement(Customer customer)
        {
            if (BuyIt(customer.TotalChanceToBuy(day.weather.actualForecast, day.weather.actualTemperature, player1.playerRecipe.lemonRecipeNumber, player1.playerRecipe.sugarRecipeNumber, player1.playerRecipe.icecubeRecipeNumber, player1.playerRecipe.priceRecipeNumber)))
            {
                
                player1.AddMoney(player1.playerRecipe.priceRecipeNumber);
                UserInterface.DisplayCash(player1);
                pitcher--;
                player1.playerInventory.numberOfCups--;
                player1.playerInventory.numberOfIcecubes -= player1.playerRecipe.icecubeRecipeNumber;
                actualCustomer++;

            }
        }
        private void GetCustomerLoop( double maxCustomer)
        {
            for (int j = 0; j < maxCustomer; j++)
            {
                if (player1.playerInventory.numberOfLemons < player1.playerRecipe.lemonRecipeNumber || player1.playerInventory.numberOfSugar < player1.playerRecipe.sugarRecipeNumber || player1.playerInventory.numberOfIcecubes < player1.playerRecipe.icecubeRecipeNumber || player1.playerInventory.numberOfCups < 1)
                {
                    Console.WriteLine("You dont have enough ingredients.");
                    break;
                }
                Customer customer = new Customer();
                GetCustomerIfStatement(customer);
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
        }
        private void GameDaysLoop(double gameDays)
        {
            for (int i = 1; i <= gameDays; i++)
            {
                double startingCash = player1.cash;
                DoPreparation();
                double cashUsed = player1.cash;
                day.ShowActualWeather();
                double maxCustomer = GenerateCustomerMaxValue(day.weather.forecastTemperature, day.weather.forecast);
                actualCustomer = 0;
                GetCustomerLoop(maxCustomer);
                UserInterface.EndDayStats(startingCash, cashUsed, maxCustomer, actualCustomer, player1);
            }
        }
    }
}





