using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.StaticDataAndMemebers.SimpleUtilityClass
{
    // Static classes can only
    // contain static members!
    public static class TimeUtilClass
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Today.ToShortDateString());
        }

        public static void PrintDateAndTime()
        {
            Console.WriteLine("**** Fun with static class ****");
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();
        }
    }
}
