using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public static class TimeofDay
    {
        public static void TimeofDayValue()
        {
            DateTime currentDateTime = DateTime.Now;
            int currentHour = currentDateTime.Hour;
            int moriningHours = 6;
            int afternoonHours = 12;
            int eveningHours = 17;
            int nightHours = 22;

            if (moriningHours <= currentHour && currentHour < afternoonHours)
            {
                Console.WriteLine("Good Morning");
            }
            if (afternoonHours <= currentHour && currentHour < eveningHours)
            {
                Console.WriteLine("Good Afternood");
            }
            if (eveningHours <= currentHour && currentHour < nightHours)
            {
                Console.WriteLine("Good Evening");
            }
            if (nightHours <= currentHour || currentHour < moriningHours)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
