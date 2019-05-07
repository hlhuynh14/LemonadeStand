using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {// member variables (HAS A)
        double TwentyFiveCups = .25;
        double FiftyCups = 50;
        double OneHundredCups = 100;
        double TenLemons = 19;
        double ThirtyLemons = 30;
        double SeventyFiveLemons = 75;
        double EightCupsOfSugar = 8;
        double TwentyCupsOfSugar = 20;
        double FortyEightCupsOfSugar = 48;
        double OneHundredIcecubes = 100;
        double TwoHundredFiftyIcecubes = 250;
        double FiveHundredIcecubes = 500;
        double TwentyFiveCupsCost = .90;
        double FiftyCupsCost = 1.64;
        double OneHundredCupsCost = 2.97;
        double TenLemonsCost = .55;
        double ThirtyLemonsCost = 2.26;
        double SeventyFiveLemonsCost = 4.24;
        double EightCupsOfSugarCost = .56;
        double TwentyCupsOfSugarCost = 1.63;
        double FortyEightCupsOfSugarCost = 3.30;
        double OneHundredIcecubesCost = .71;
        double TwoHundredFiftyIcecubesCost = 2.10;
        double FiveHundredIcecubesCost = 3.56;


        // constructor

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
