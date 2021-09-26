using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter4.NullableTypes
{
    public class DatabaseReader
    {
        //Nullable data field
        public int? numericValue = null;
        public bool? boolValue = true;

        //Note the nullable return type
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }

        public static void ReadData()
        {
            Console.WriteLine("***** Fun with nullable data type *****\n");

            DatabaseReader dr = new DatabaseReader();
            //Get int from "database"
            int? i = dr.GetIntFromDatabase();

            if(i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            else
                Console.WriteLine("Value of 'i' is undefined");

            //Get bool from "database"
            bool? b = dr.GetBoolFromDatabase();
            if(b != null)
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            else
                Console.WriteLine("Value of 'b' is undefined");
            Console.ReadLine();
        }

        /// <summary>
        /// this operator allows you to assign a value to nullable type
        /// if retrieved value is infact null
        /// </summary>
        public static void NullCoalescingOperator()
        {
            Console.WriteLine("***** Fun with nullable data *****\n");
            DatabaseReader dr = new DatabaseReader();

            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of the myData: {0}", myData);
            Console.ReadLine();
        }

        public static void TraditionalIfElse()
        {
            Console.WriteLine("***** Fun with nullable data *****\n");
            DatabaseReader dr = new DatabaseReader();

            //Long-hand notation not using ?? syntax
            int? moreData = dr.GetIntFromDatabase();

            if (!moreData.HasValue)
                moreData = 100;
            Console.WriteLine("Value of moreData: {0}", moreData);
        }

        public static void TesterMethod(string[] args)
        {
            //we should check for null before accessing the array data!
            /*if (args != null)
            {
                Console.WriteLine($"You sent me {args.Length} arguments.");
            }*/

            //null conditional operator
            Console.WriteLine($"You sent me {args?.Length} arguments");

            //assigning a default value if args is null using null coalescing operator
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments");
        }

        public static void TesterMethod()
        {
            TesterMethod(null);
            string[] str = { "To", "Do", "List" };
            TesterMethod(str);
        }
    }
}
