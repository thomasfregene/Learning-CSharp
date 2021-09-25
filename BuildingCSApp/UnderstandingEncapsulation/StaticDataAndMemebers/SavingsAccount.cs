using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter5.UnderstandingEncapsulation.StaticDataAndMemebers
{
    public class SavingsAccount
    {
        //instance-level data
        public double CurrAccount;
        //a static point of data
        public static double CurrInterestRate = 0.04;
        public SavingsAccount(double balance)
        {
            CurrAccount = balance;
        }
        
        //When you create SavingsAccount objects, memory for the
        //currBalance field is allocated for each object.
        public static void AccountBal()
        {
            Console.WriteLine("***** Fun With Static Data *****\n");
            SavingsAccount s1 = new SavingsAccount(50);
            Console.WriteLine("s1: {0}\n", s1);
            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("s2: {0}\n", s2);
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("s3: {0}", s3);

            Console.ReadLine();
        }

    }
}
