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
     public static void DisplayWeatherForecast( double temperature, string forecast)
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
     public static double AskHowMany(string item, double FirstChoice, double FirstPrice, double SecondChoice, double SecondPrice, double ThirdChoice, double ThirdPrice)
     {
            Console.WriteLine($"How many {item} would you like? either {FirstChoice} for ${FirstPrice}, {SecondChoice} for ${SecondPrice} or {ThirdChoice} for ${ThirdPrice}.");
            int answer; 
                Int32.TryParse(Console.ReadLine(), out answer);
            if ( answer == 0)
            {
                BadInput();
               return AskHowMany(item, FirstChoice, FirstPrice, SecondChoice, SecondPrice, ThirdChoice, ThirdPrice);
            }
            else if (answer == FirstChoice)
            {
                return answer;
            }
            else if (answer == SecondChoice)
            {
                return answer;
            }
            else if (answer == ThirdChoice)
            {
                return answer;
            }
            else
            {
                Console.WriteLine("That wasnt a choice.");
                return AskHowMany(item, FirstChoice, FirstPrice, SecondChoice, SecondPrice, ThirdChoice, ThirdPrice);
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
        public static void DisplayTotalProfit(double StartingCash, double CurrentCash)
        {
            double TotalProfit = CurrentCash - StartingCash;

            if (TotalProfit > 0)
            {
                Console.WriteLine($"You made ${TotalProfit} so far! ");
            }
            else
            {
                Console.WriteLine($"You lost $ {TotalProfit} so far!");

            }
        }
        public static void DisplayProfit(double StartingCash, double CurrentCash)
        {
            double NetProfit = CurrentCash - StartingCash;

            if (NetProfit > 0)
            {
                Console.WriteLine($"Your net profit for today is ${NetProfit}. ");
            }
            else
            {
                Console.WriteLine($"Your net lost for today is ${NetProfit}.");

            }
        }
        public static void GetCustomers(double PotentialCustomer, double ActualCustomers)
        {
            Console.WriteLine($"{ActualCustomers} customers bought your lemonade out of {PotentialCustomer} potential customers.");
        }
        public static void EndgameNotice(Player player, double StartingCash)
        {
            double NetCash = player.cash - StartingCash;
            if (NetCash > 0)
            {
                Console.WriteLine($"Your sales are over, you made ${NetCash}!");
            }
            else
            {
                Console.WriteLine($"Your sales are over, you lost ${NetCash}!");
            }
        }
    }
}
