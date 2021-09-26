using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class SystemConsoleClass
    {
        public static void GetConsoleClass()
        {
            Console.Beep();
 
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Hello World!!!");
        }
    }
}
