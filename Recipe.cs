using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {// member variables (HAS A)
        public double lemonRecipeNumber;
        public double sugarRecipeNumber;
        public double icecubeRecipeNumber;
        public double priceRecipeNumber;

        // constructor
        public Recipe()
        {
            lemonRecipeNumber = 6;
            sugarRecipeNumber = 4;
            icecubeRecipeNumber = 4;
            priceRecipeNumber = .25;
 

        }

        // member methods (CAN DO)

        

        public void NewRecipe(Player player)
        {

            int lemons;
            Console.WriteLine("What would you like to change the amount of lemons per pitcher into?");
            Int32.TryParse(Console.ReadLine(), out lemons);
            if (lemons == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
              NewRecipe(player);
            }
            int cupsOfSugar;
            Console.WriteLine("What would you like to change the amount of cups of sugar per pitcher to be?");
            int.TryParse(Console.ReadLine(), out cupsOfSugar);
            if (cupsOfSugar == 0)
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
            double pricePerCup;
            Console.WriteLine("What would you like to change the price per cup to be? Too high and customers wont buy! ALSO, ENTER A NUMBER WITH A DECIMAL OR YOU WILL BE CHARGING IN DOLLARS PER CUP!" );
            double.TryParse(Console.ReadLine(), out pricePerCup);
            if (pricePerCup == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
                NewRecipe(player);
            }
           ChangeRecipe(lemons, cupsOfSugar, icecubes, pricePerCup);
            UserInterface.RecipeSatisfaction(player);

        }
        private void ChangeRecipe( double lemons, double sugar, double icecubes, double PricePerCup)
        {
            lemonRecipeNumber = lemons;
            sugarRecipeNumber = sugar;
            icecubeRecipeNumber = icecubes;
            priceRecipeNumber = PricePerCup;
        }
    }
}
