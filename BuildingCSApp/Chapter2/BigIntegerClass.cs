using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter2
{
    public static class BigIntegerClass
    {
        public static void BigIntMethod()
        {
            BigInteger big = new BigInteger();
            big = BigInteger.Parse("9999999999999999999999999");
            var multiply = big * 67;
            Console.WriteLine("Multiply BigInt by 67: {0}",multiply);
            Console.WriteLine("BigInteger: {0}", big);
        }
    }
}
