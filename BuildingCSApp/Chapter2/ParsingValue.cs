using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class ParsingValue
    {
        public static void ParseFromString()
        {
            Console.WriteLine("=> Data type parsing");
            bool b = bool.Parse("True");
            Console.WriteLine("value of b: {0}", b);
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i*2);
            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }
    }
}
