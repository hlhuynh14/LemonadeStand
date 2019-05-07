using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {// member variables (HAS A)
       public List<double> inventory;
     // constructor
     public Inventory()
        {
         List<double> inventory = new List<double> { 0, 0, 0, 0 };

        }
     // member methods (CAN DO)
     public void CheckInventory()
        {
            Console.WriteLine($"You have {inventory[1]} cups of sugar.");
            Console.WriteLine($"You have {inventory[2]} lemons.");
            Console.WriteLine($"You have {inventory[3]} icecubes.");
            Console.WriteLine($"You have {inventory[4]} cups.");

        }
    }
}
