using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class BasicDataType
    {
        public static void LocalVArDeclaration()
        {
            Console.WriteLine("=> Data Declarations:");
            //Local variables are declared as so
            //dataType varName = initial value
            int myInt = 0;
            string myString = "this is a string data";
            //assigning values on another line
            myInt = 2;
            myString = "Initializing after declaration";
            Console.WriteLine();
            //declare multiple variable with the same dataType in a single line
            bool b1 = true, b2 = false, b3 = true;
            Console.WriteLine("Your Data: {0}, {1}, {2}, {3}, {4}", myInt, myString, b1, b2, b3);
        }

        public static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables");
            bool b = new bool(); //set to false
            int i = new int(); //set to 0
            double d = new double(); //set to 0
            DateTime dt = new DateTime(); //set to 1/1/0001 12:00:00 AM
            Console.WriteLine();
            Console.WriteLine("Boolean Default Value: {0},", b);
            Console.WriteLine();
            Console.WriteLine("Interger Default Value: {0}", i);
            Console.WriteLine();
            Console.WriteLine("double Default Value: {0}", d);
            Console.WriteLine();
            Console.WriteLine("DateTime Default Value: {0}", dt);
        }
    }
}
