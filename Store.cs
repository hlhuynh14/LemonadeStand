using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
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
        double FiftyCupsCost ;
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
        public double CashForCups(double cash, double cups)
     {
            cash = cash - cups;
            return cash;

     }
     public double CashForLemons(double cash, double lemons)
     {
            cash = cash - lemons;
            return cash;

     }
     public double CashForSugar(double cash, double sugar)
     {
            cash = cash - sugar;
            return cash;

     }

     public double CashForIcecubes(double cash, double icecubes)
     {
            cash = cash - icecubes;
            return cash;

     }
     public double CupsForCash(double PlayerCups, double cups)
     {
            PlayerCups = PlayerCups + cups;
            return PlayerCups;

     }
     public double LemonsForCash(double PlayerLemons, double lemons)
     {
            PlayerLemons = PlayerLemons + lemons;
            return PlayerLemons;

     }
     public double SugarForCash(double PlayerSugar, double sugar)
     {
            PlayerSugar = PlayerSugar + sugar;
            return PlayerSugar;
     }
     public double IcecubesForCash(double PlayerIcecubes, double icecubes)
     {
            PlayerIcecubes = PlayerIcecubes + icecubes;
            return PlayerIcecubes;

     }


    }
}
