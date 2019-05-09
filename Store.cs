using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {// member variables (HAS A)
        double twentyFiveCups;
        double fiftyCups;
        double oneHundredCups;
        double tenLemons;
        double thirtyLemons;
        double seventyFiveLemons;
        double eightCupsOfSugar;
        double twentyCupsOfSugar;
        double fortyEightCupsOfSugar;
        double oneHundredIcecubes;
        double twoHundredFiftyIcecubes;
        double fiveHundredIcecubes;
        double twentyFiveCupsCost;
        double fiftyCupsCost;
        double oneHundredCupsCost;
        double tenLemonsCost;
        double thirtyLemonsCost;
        double seventyFiveLemonsCost;
        double eightCupsOfSugarCost;
        double twentyCupsOfSugarCost;
        double fortyEightCupsOfSugarCost;
        double oneHundredIcecubesCost;
        double twoHundredFiftyIcecubesCost;
        double fiveHundredIcecubesCost;


        // constructor
        public Store()
        {
            twentyFiveCups = 25;
            fiftyCups = 50;
            oneHundredCups = 100;
            tenLemons = 10;
            thirtyLemons = 30;
            seventyFiveLemons = 75;
            eightCupsOfSugar = 8;
            twentyCupsOfSugar = 20;
            fortyEightCupsOfSugar = 48;
            oneHundredIcecubes = 100;
            twoHundredFiftyIcecubes = 250;
            fiveHundredIcecubes = 500;
            twentyFiveCupsCost = .90;
            fiftyCupsCost = 1.64;
            oneHundredCupsCost = 2.97;
            tenLemonsCost = .55;
            thirtyLemonsCost = 2.26;
            seventyFiveLemonsCost = 4.24;
            eightCupsOfSugarCost = .56;
            twentyCupsOfSugarCost = 1.63;
            fortyEightCupsOfSugarCost = 3.30;
            oneHundredIcecubesCost = .71;
            twoHundredFiftyIcecubesCost = 2.10;
            fiveHundredIcecubesCost = 3.56;
        }


        // member methods (CAN DO)

        private void CashForCups(Player player, double priceOfCups, double numberOfCupsAdded )
        {
            player.cash = player.cash - priceOfCups;
            player.playerInventory.numberOfCups = player.playerInventory.numberOfCups + numberOfCupsAdded;


        }
        private void CashForLemons(Player player, double PriceOfLemons, double NumberOfLemonsAdded)
        {
            player.cash = player.cash - PriceOfLemons;
            player.playerInventory.numberOfLemons = player.playerInventory.numberOfLemons + NumberOfLemonsAdded;


        }
        private void CashForSugar(Player player, double PriceOfSugar, double NumberOfSugarAdded)
        {
            player.cash = player.cash - PriceOfSugar;
            player.playerInventory.numberOfSugar = player.playerInventory.numberOfSugar + NumberOfSugarAdded;


        }
        private void CashForIcecubes(Player player, double PriceOfIcecubes, double NumberOfIcecubesAdded)
        {
            player.cash = player.cash - PriceOfIcecubes;
            player.playerInventory.numberOfIcecubes = player.playerInventory.numberOfIcecubes + NumberOfIcecubesAdded;


        }
        public  void BuyingItems(Player player)
        {
            Console.WriteLine("What would like to buy? cups, lemons, sugar, iceCubes or enter exit to exit the store.");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "cups":
                    double cups = UserInterface.AskHowMany("cups", twentyFiveCups, twentyFiveCupsCost, fiftyCups, fiftyCupsCost, oneHundredCups, oneHundredCupsCost);
                    HowManyCups(player, cups);
                    LoopStore(player);
                    break;
                case "lemons":
                    double lemons = UserInterface.AskHowMany("lemons", tenLemons, tenLemonsCost, thirtyLemons, thirtyLemonsCost, seventyFiveLemons, seventyFiveLemonsCost);
                    HowManyLemons(player, lemons);
                    LoopStore(player);
                    break;
                case "sugar":
                    double cupsofsugar = UserInterface.AskHowMany("cups of sugar", eightCupsOfSugar, eightCupsOfSugarCost, twentyCupsOfSugar, twentyCupsOfSugarCost, fortyEightCupsOfSugar, fortyEightCupsOfSugarCost);
                    HowManySugar(player, cupsofsugar);
                    LoopStore(player);
                    break;
                case "icecubes":
                    double icecubes = UserInterface.AskHowMany("icecubes", oneHundredIcecubes, oneHundredIcecubesCost, twoHundredFiftyIcecubes, twoHundredFiftyIcecubesCost, fiveHundredIcecubes, fiveHundredIcecubesCost);
                    HowManyIcecubes(player, icecubes);
                    LoopStore(player);
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("You enter a wrong input, please try again!");
                    BuyingItems(player);
                    break;

            }
        }
        private void HowManyCups(Player player, double cups)
        {
            switch (cups)
            {
                case 25:
                    CashForCups(player, twentyFiveCupsCost, twentyFiveCups);
                    break;
                case 50:
                    CashForCups(player, fiftyCupsCost, fiftyCups);
                    break;
                case 100:
                    CashForCups(player, oneHundredCupsCost, oneHundredCups);
                    break;
                default:
                    break;
            }
        }
        private void HowManyLemons(Player player, double lemons)
        {
            switch (lemons)
            {
                case 10:
                    CashForLemons(player, tenLemonsCost, tenLemons);
                    break;
                case 30:
                    CashForLemons(player, thirtyLemonsCost, thirtyLemons);
                    break;
                case 75:
                    CashForLemons(player, seventyFiveLemonsCost, seventyFiveLemons);
                    break;
                default:
                    break;
            }
        }
        private void HowManySugar(Player player, double sugar)
        {
            switch (sugar)
            {
                case 8:
                    CashForSugar(player, eightCupsOfSugarCost, eightCupsOfSugar);
                    break;
                case 20:
                    CashForSugar(player, twentyCupsOfSugarCost, twentyCupsOfSugar);
                    break;
                case 48:
                    CashForSugar(player, fortyEightCupsOfSugarCost, fortyEightCupsOfSugar);
                    break;
                default:
                    break;
            }
        }
        public void HowManyIcecubes(Player player, double icecubes)
        {
            switch (icecubes)
            {
                case 100:
                    CashForIcecubes(player, oneHundredIcecubesCost, oneHundredIcecubes);
                    break;
                case 250:
                    CashForIcecubes(player, twoHundredFiftyIcecubesCost, twoHundredFiftyIcecubes);
                    break;
                case 500:
                    CashForIcecubes(player, fiveHundredIcecubesCost, fiveHundredIcecubes);
                    break;
                default:
                    break;
            }
        }
        private void LoopStore(Player player)
        {
            UserInterface.CheckInventory(player.playerInventory.numberOfCups, player.playerInventory.numberOfLemons, player.playerInventory.numberOfSugar, player.playerInventory.numberOfIcecubes);
            UserInterface.DisplayCash(player);
            BuyingItems(player);
        }
    }
}
