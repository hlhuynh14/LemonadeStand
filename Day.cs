using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {// member variables (HAS A)
    double TimeOfDay;

     // constructor
        
     public Day()
     { TimeOfDay = 9;
            Weather WeatherToday = new Weather();

        }

     // member methods (CAN DO)
     public double AddHour(double TimeOfDay)
     {
       TimeOfDay = TimeOfDay + 1;
            return TimeOfDay;
     }
    }
}


