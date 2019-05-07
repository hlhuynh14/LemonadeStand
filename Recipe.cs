using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {// member variables (HAS A)
        public List<double> recipe;
        // constructor
        public Recipe()
        {
            List<double> recipe = new List<double> { 6, 4, 4, 25 };

        }

        // member methods (CAN DO)

        

        public void NewRecipe()
        {

            int CupsOfSugar;
            Console.WriteLine("What would you like to change the amount of cups of sugar per pitcher into?");
            Int32.TryParse(Console.ReadLine(), out CupsOfSugar);
            if (CupsOfSugar == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
              NewRecipe();
            }
            int lemons;
            Console.WriteLine("What would you like to change the amount of lemons per pitcher to be?");
            int.TryParse(Console.ReadLine(), out lemons);
            if (lemons == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
              NewRecipe();
            }
            int icecubes;
            Console.WriteLine("What would you like to change the amount of icecubes per cup sold to?");
            int.TryParse(Console.ReadLine(), out icecubes);
            if (icecubes == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
              NewRecipe();
            }
            int PricePerCup;
            Console.WriteLine("What would you like to change the price per cup to be?");
            int.TryParse(Console.ReadLine(), out PricePerCup);
            if (PricePerCup == 0)
            {
                Console.WriteLine("Please enter a number next time or you will have start all over!");
                NewRecipe();
            }
            ChangeRecipe(CupsOfSugar, lemons, icecubes, PricePerCup);

        }
        public List<double> ChangeRecipe(double sugar, double lemons, double icecubes, double PricePerCup)
        {
            recipe = new List<double> { sugar, lemons, icecubes, PricePerCup };
            return recipe;
        }
    }
}
