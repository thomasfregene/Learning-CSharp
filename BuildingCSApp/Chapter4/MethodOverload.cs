using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter4
{
    public class MethodOverload
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static long Add(long x, long y)
        {
            return x + y;
        }

        public static void InvokingAddMethod()
        {
            //calls int version of add
            Console.WriteLine("Adding Intergers: {0}", Add(4, 4));
            //calls long version of add
            Console.WriteLine("Adding Intergers: {0}", Add(400000000000, 40000000000));
            //calls double version of add
            Console.WriteLine("Adding Intergers: {0}", Add(4.54, 4.66));
        }
    }
}
