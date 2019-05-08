using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {// member variables (HAS A)
        public List<double> recipe;
        // constructor
        public Recipe()
        {
             recipe = new List<double> { 6, 4, 4, .25 };

        }

        // member methods (CAN DO)

        

        public void NewRecipe(Player player)
        {

            int CupsOfSugar;
            Console.WriteLine("What would you like to change the amount of cups of sugar per pitcher into?");
            Int32.TryParse(Console.ReadLine(), out CupsOfSugar);
            if (CupsOfSugar == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
              NewRecipe(player);
            }
            int lemons;
            Console.WriteLine("What would you like to change the amount of lemons per pitcher to be?");
            int.TryParse(Console.ReadLine(), out lemons);
            if (lemons == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
              NewRecipe(player);
            }
            int icecubes;
            Console.WriteLine("What would you like to change the amount of icecubes per cup sold to?");
            int.TryParse(Console.ReadLine(), out icecubes);
            if (icecubes == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
              NewRecipe(player);
            }
            double PricePerCup;
            Console.WriteLine("What would you like to change the price per cup to be? Too high and customers wont buy!" );
            double.TryParse(Console.ReadLine(), out PricePerCup);
            if (PricePerCup == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
                NewRecipe(player);
            }
            ChangeRecipe(player, CupsOfSugar, lemons, icecubes, PricePerCup);

        }
        public void ChangeRecipe(Player player, double sugar, double lemons, double icecubes, double PricePerCup)
        {
            player.PlayerRecipe.recipe = new List<double> { sugar, lemons, icecubes, PricePerCup };
           
        }
    }
}
