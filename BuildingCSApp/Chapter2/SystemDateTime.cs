using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter2
{
     public static class SystemDateTime
    {
        public static void UsingDateAndTime()
        {
            Console.WriteLine("=> Dates and Times");
            //this costructor takes (year, month, day)
            DateTime dt = new DateTime(2010, 8, 3);

            //what day of the month is it
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
        }
    }
}
