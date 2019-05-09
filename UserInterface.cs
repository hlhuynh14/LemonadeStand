using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {// member variables (HAS A)



        // constructor



        // member methods (CAN DO)
        public static void DisplayWeatherForecast(double temperature, string forecast)
        {
            Console.WriteLine($"Temperature forecast: {temperature}");
            Console.WriteLine($"Forecast: {forecast}");

        }
        public static void DisplayActualWeatherForecast(double temperature, string forecast)
        {
            Console.WriteLine($"Temperature: {temperature}");
            Console.WriteLine($"Actual Weather: {forecast}");

        }
        public static void CheckInventory(double cups, double lemons, double sugar, double icecubes)
        {
            Console.WriteLine($"You have {cups} cups.");
            Console.WriteLine($"You have {lemons} lemons.");
            Console.WriteLine($"You have {sugar} cups of sugar.");
            Console.WriteLine($"You have {icecubes} icecubes.");

        }
        public static void GoToStore(Store store, Player player)
        {
            Console.WriteLine("Do you want to go to the store to buy materials? enter yes or no.");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                store.BuyingItems(player);
            }
            else if (answer == "no")
            {

            }
            else
            {
                Console.WriteLine("Choose yes or no.");
                GoToStore(store, player);
            }
        }
        public static double AskHowMany(string item, double firstChoice, double firstPrice, double secondChoice, double secondPrice, double thirdChoice, double thirdPrice)
        {
            Console.WriteLine($"How many {item} would you like? either {firstChoice} for ${firstPrice}, {secondChoice} for ${secondPrice} or {thirdChoice} for ${thirdPrice}.");
            int answer;
            Int32.TryParse(Console.ReadLine(), out answer);
            if (answer == 0)
            {
                BadInput();
                return AskHowMany(item, firstChoice, firstPrice, secondChoice, secondPrice, thirdChoice, thirdPrice);
            }
            else if (answer == firstChoice)
            {
                return answer;
            }
            else if (answer == secondChoice)
            {
                return answer;
            }
            else if (answer == thirdChoice)
            {
                return answer;
            }
            else
            {
                Console.WriteLine("That wasnt a choice.");
                return AskHowMany(item, firstChoice, firstPrice, secondChoice, secondPrice, thirdChoice, thirdPrice);
            }
        }
        public static void DisplayCash(Player player)
        {
            Console.WriteLine($"You have ${player.cash}.");
        }
        public static void BadInput()
        {
            Console.WriteLine(" That is not a correct input, please try again!");
        }
        public static void DisplayTotalProfit(double startingCash, double currentCash)
        {
            double totalProfit = currentCash - startingCash;

            if (totalProfit > 0)
            {
                Console.WriteLine($"You made ${totalProfit} so far! ");
            }
            else
            {
                Console.WriteLine($"You lost $ {totalProfit} so far!");

            }
        }
        public static void DisplayProfit(double startingCash, double currentCash)
        {
            double netProfit = currentCash - startingCash;

            if (netProfit > 0)
            {
                Console.WriteLine($"Your net profit for today is ${netProfit}. ");
            }
            else
            {
                Console.WriteLine($"Your net lost for today is ${netProfit}.");

            }
        }
        public static void GetCustomers(double potentialCustomer, double actualCustomers)
        {
            Console.WriteLine($"{actualCustomers} customers bought your lemonade out of {potentialCustomer} potential customers.");
        }
        public static void EndgameNotice(Player player, double startingCash)
        {

            double netCash = player.cash - startingCash;
            if (netCash > 0)
            {
                Console.WriteLine($"Your sales are over, you made ${netCash}!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Your sales are over, you lost ${netCash}!");
                Console.ReadLine();
            }
        }
        public static void AlterRecipe(Player player)
        {
            Console.WriteLine("Do you want to change your recipe? enter yes or no.");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                player.playerRecipe.NewRecipe(player);
            }
            else if (answer == "no")
            {

            }
            else
            {
                Console.WriteLine("Choose yes or no.");
                AlterRecipe(player);
            }
        }
        public static void ShowRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand, choose the best recipes to attract customer who will come out based on the weather. Remember to keep your supplies up or you will run out midday.");
        }
        public static void ShowRecipe(double lemons, double sugar, double icecubes, double price)
        {
            Console.WriteLine($"Your current recipe is {lemons} lemons and {sugar} cups of sugar per pitcher. You put in {icecubes} icecubes per cup, and you set your price to be ${price} for each cup.");
        }
        public static void RecipeSatisfaction(Player player)
        {
            Console.WriteLine("Are you satisfy with your recipe?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                UserInterface.ShowRecipe(player.playerRecipe.lemonRecipeNumber, player.playerRecipe.sugarRecipeNumber, player.playerRecipe.icecubeRecipeNumber, player.playerRecipe.priceRecipeNumber);
            }
            else if (answer == "no")
            {
                AlterRecipe(player);
            }
            else
            {
                Console.WriteLine("Choose yes or no.");
                RecipeSatisfaction(player);
            }
        }
        public static double AskGameDays()
        {
            Console.WriteLine("How long should your sale last? in days.");
            int answer;
            Int32.TryParse(Console.ReadLine(), out answer);
            if (answer == 0)
            {
                Console.WriteLine("Please enter a number next time");
               return AskGameDays();
            }
            else
            {
                return answer;
            }
        }
    }
}
