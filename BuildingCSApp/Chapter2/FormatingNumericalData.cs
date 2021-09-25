using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter2
{
    public static class FormatingNumericalData
    {
        public static void FormatNumericData()
        {
            Console.WriteLine("The value of 99999 in various formats:");

            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);

            /*NB that upper or lowercasing for hex determines
             if letters are upper or lowercase*/
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }

        public static void DisplayMessage()
        {
            string message = string.Format("100000 in hex is {0:x}", 100000);

            System.Windows.MessageBox.Show(message);
        }
    }
}
