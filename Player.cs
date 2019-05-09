using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {// member variables (HAS A)
        public double cash;
        public Inventory PlayerInventory;
        public Recipe PlayerRecipe;
     // constructor
     public Player()
        {
            cash = 20;
             PlayerInventory = new Inventory();
             PlayerRecipe = new Recipe();

        }

     // member methods (CAN DO)
     public void AddMoney(double price)
     {
            cash += price;
     }
     
    }

}
