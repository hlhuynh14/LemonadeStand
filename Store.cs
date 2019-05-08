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
            TwentyFiveCups = 25;
            FiftyCups = 50;
            OneHundredCups = 100;
            TenLemons = 10;
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
            Console.WriteLine("What would like to buy? cups, lemons, sugar, iceCubes or enter exit to exit the store.");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "cups":
                    double cups = UserInterface.AskHowMany("cups", TwentyFiveCups, TwentyFiveCupsCost, FiftyCups, FiftyCupsCost, OneHundredCups, OneHundredCupsCost);
                    HowManyCups(player, cups, player.cash);
                    UserInterface.CheckInventory(player.PlayerInventory.inventory[0], player.PlayerInventory.inventory[1], player.PlayerInventory.inventory[2], player.PlayerInventory.inventory[3]);
                    UserInterface.DisplayCash(player);
                    BuyingItems(player);
                    break;
                case "lemons":
                    double lemons = UserInterface.AskHowMany("lemons", TenLemons, TenLemonsCost, ThirtyLemons, ThirtyLemonsCost, SeventyFiveLemons, SeventyFiveLemonsCost);
                    HowManyLemons(player, lemons, player.cash);
                    UserInterface.CheckInventory(player.PlayerInventory.inventory[0], player.PlayerInventory.inventory[1], player.PlayerInventory.inventory[2], player.PlayerInventory.inventory[3]);
                    UserInterface.DisplayCash(player);
                    BuyingItems(player);
                    break;
                case "sugar":
                    double cupsofsugar = UserInterface.AskHowMany("cups of sugar", EightCupsOfSugar, EightCupsOfSugarCost, TwentyCupsOfSugar, TwentyCupsOfSugarCost, FortyEightCupsOfSugar, FortyEightCupsOfSugarCost);
                    HowManySugar(player, cupsofsugar, player.cash);
                    UserInterface.CheckInventory(player.PlayerInventory.inventory[0], player.PlayerInventory.inventory[1], player.PlayerInventory.inventory[2], player.PlayerInventory.inventory[3]);
                    UserInterface.DisplayCash(player);
                    BuyingItems(player);
                    break;
                case "icecubes":
                    double icecubes = UserInterface.AskHowMany("icecubes", OneHundredIcecubes, OneHundredIcecubesCost, TwoHundredFiftyIcecubes, TwoHundredFiftyIcecubesCost, FiveHundredIcecubes, FiveHundredIcecubesCost);
                    HowManyIcecubes(player, icecubes, player.cash);
                    UserInterface.CheckInventory(player.PlayerInventory.inventory[0], player.PlayerInventory.inventory[1], player.PlayerInventory.inventory[2], player.PlayerInventory.inventory[3]);
                    UserInterface.DisplayCash(player);
                    BuyingItems(player);
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("You enter a wrong input, please try again!");
                    BuyingItems(player);
                    break;

            }
        }
        public void HowManyCups(Player player, double cups, double cash)
        {
            switch (cups)
            {
                case 25:
                    CashForCups(player, TwentyFiveCupsCost, TwentyFiveCups);
                    break;
                case 50:
                    CashForCups(player, FiftyCupsCost, FiftyCups);
                    break;
                case 100:
                    CashForCups(player, OneHundredCupsCost, OneHundredCups);
                    break;
                default:
                    break;
            }
        }
        public void HowManyLemons(Player player, double lemons, double cash)
        {
            switch (lemons)
            {
                case 10:
                    CashForLemons(player, TenLemonsCost, TenLemons);
                    break;
                case 30:
                    CashForLemons(player, ThirtyLemonsCost, ThirtyLemons);
                    break;
                case 75:
                    CashForLemons(player, SeventyFiveLemonsCost, SeventyFiveLemons);
                    break;
                default:
                    break;
            }
        }
        public void HowManySugar(Player player, double sugar, double cash)
        {
            switch (sugar)
            {
                case 8:
                    CashForSugar(player, EightCupsOfSugarCost, EightCupsOfSugar);
                    break;
                case 20:
                    CashForSugar(player, TwentyCupsOfSugarCost, TwentyCupsOfSugar);
                    break;
                case 48:
                    CashForSugar(player, FortyEightCupsOfSugarCost, FortyEightCupsOfSugar);
                    break;
                default:
                    break;
            }
        }
        public void HowManyIcecubes(Player player, double icecubes, double cash)
        {
            switch (icecubes)
            {
                case 100:
                    CashForIcecubes(player, OneHundredIcecubesCost, OneHundredIcecubes);
                    break;
                case 250:
                    CashForIcecubes(player, TwoHundredFiftyIcecubesCost, TwoHundredFiftyIcecubes);
                    break;
                case 500:
                    CashForIcecubes(player, FiveHundredIcecubesCost, FiveHundredIcecubes);
                    break;
                default:
                    break;
            }
        }
    }
}
