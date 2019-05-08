using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {// member variables (HAS A)
        double TwentyFiveCups;
        double FiftyCups;
        double OneHundredCups;
        double TenLemons;
        double ThirtyLemons;
        double SeventyFiveLemons;
        double EightCupsOfSugar;
        double TwentyCupsOfSugar;
        double FortyEightCupsOfSugar;
        double OneHundredIcecubes;
        double TwoHundredFiftyIcecubes;
        double FiveHundredIcecubes;
        double TwentyFiveCupsCost;
        double FiftyCupsCost;
        double OneHundredCupsCost;
        double TenLemonsCost;
        double ThirtyLemonsCost;
        double SeventyFiveLemonsCost;
        double EightCupsOfSugarCost;
        double TwentyCupsOfSugarCost;
        double FortyEightCupsOfSugarCost;
        double OneHundredIcecubesCost;
        double TwoHundredFiftyIcecubesCost;
        double FiveHundredIcecubesCost;


        // constructor
        public Store()
        {
            TwentyFiveCups = .25;
            FiftyCups = 50;
            OneHundredCups = 100;
            TenLemons = 19;
            ThirtyLemons = 30;
            SeventyFiveLemons = 75;
            EightCupsOfSugar = 8;
            TwentyCupsOfSugar = 20;
            FortyEightCupsOfSugar = 48;
            OneHundredIcecubes = 100;
            TwoHundredFiftyIcecubes = 250;
            FiveHundredIcecubes = 500;
            TwentyFiveCupsCost = .90;
            FiftyCupsCost = 1.64;
            OneHundredCupsCost = 2.97;
            TenLemonsCost = .55;
            ThirtyLemonsCost = 2.26;
            SeventyFiveLemonsCost = 4.24;
            EightCupsOfSugarCost = .56;
            TwentyCupsOfSugarCost = 1.63;
            FortyEightCupsOfSugarCost = 3.30;
            OneHundredIcecubesCost = .71;
            TwoHundredFiftyIcecubesCost = 2.10;
            FiveHundredIcecubesCost = 3.56;
        }


        // member methods (CAN DO)
        public void CashForCups(Player player, double PriceOfCups, double NumberOfCups)
        {
            player.cash = player.cash - PriceOfCups;
            player.PlayerInventory.inventory[0] = player.PlayerInventory.inventory[0] + NumberOfCups;


        }
        public void CashForLemons(Player player, double PriceOfLemons, double NumberOfLemons)
        {
            player.cash = player.cash - PriceOfLemons;
            player.PlayerInventory.inventory[1] = player.PlayerInventory.inventory[1] + NumberOfLemons;


        }
        public void CashForSugar(Player player, double PriceOfSugar, double NumberOfSugar)
        {
            player.cash = player.cash - PriceOfSugar;
            player.PlayerInventory.inventory[2] = player.PlayerInventory.inventory[2] + NumberOfSugar;


        }
        public void CashForIcecubes(Player player, double PriceOfIcecubes, double NumberOfIcecubes)
        {
            player.cash = player.cash - PriceOfIcecubes;
            player.PlayerInventory.inventory[3] = player.PlayerInventory.inventory[3] + NumberOfIcecubes;


        }
        public  void BuyingItems(Player player)
        {
            Console.WriteLine("What would like to buy? Cups, Lemons, Sugar, or Icecubes");
            string answer = Console.ReadLine();
            UserInterface.CheckInventory(player.PlayerInventory.inventory[0], player.PlayerInventory.inventory[1], player.PlayerInventory.inventory[2], player.PlayerInventory.inventory[3]);
            switch (answer)
            {
                case "Cups":



                default:
                    break;

            }
        }
    }
}
