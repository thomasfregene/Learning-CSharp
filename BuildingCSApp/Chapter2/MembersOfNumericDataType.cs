using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class MembersOfNumericDataType
    {
        public static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data Type functionality");
            Console.WriteLine("max of int: {0}", int.MaxValue);
            Console.WriteLine("min of int: {0}", int.MinValue);
            Console.WriteLine("max of double: {0}", double.MaxValue);
            Console.WriteLine("min of double: {0}", double.MinValue);

            Console.WriteLine("double.PositiveInfnity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativityInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
        }
    }
}
