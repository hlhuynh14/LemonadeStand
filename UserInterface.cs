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
            Console.WriteLine($"Temperature: {temperature}");
            Console.WriteLine($"Forecast: {forecast}");

     }
     public static void CheckInventory(double sugar, double lemons, double icecubes, double cups)
     {
            Console.WriteLine($"You have {sugar} cups of sugar.");
            Console.WriteLine($"You have {lemons} lemons.");
            Console.WriteLine($"You have {icecubes} icecubes.");
            Console.WriteLine($"You have {cups} cups.");

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

     
    }
}
