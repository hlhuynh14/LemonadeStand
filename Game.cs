using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {// member variables (HAS A)
        public Human Player1;
        public Store GameStore;
     // constructor
     public Game()
        {
            Human Player1 = new Human();
            Store GameStore = new Store();
            
        }
     // member methods (CAN DO)
     public void StartGame()
     {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                day.ShowWeather();
                UserInterface.CheckInventory(Player1.PlayerInventory.inventory[0], Player1.PlayerInventory.inventory[1], Player1.PlayerInventory.inventory[2], Player1.PlayerInventory.inventory[3]);
                UserInterface.GoToStore(GameStore, Player1);
                UserInterface.CheckInventory(Player1.PlayerInventory.inventory[0], Player1.PlayerInventory.inventory[1], Player1.PlayerInventory.inventory[2], Player1.PlayerInventory.inventory[3]);

            }
     }  
    }
}
