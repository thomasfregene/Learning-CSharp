using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.StaticDataAndMemebers
{
    public class SavingsAccount
    {
        //instance-level data
        public double CurrBalance;
        //a static point of data
        public static double CurrInterestRate;// = 0.04;

        // Notice that our constructor is setting
        // the static currInterestRate value.
        public SavingsAccount(double balance)
        {
            //CurrInterestRate = 0.04;
            CurrBalance = balance;
        }

        //static constructor
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor");
            CurrInterestRate = 0.04;
        }
        
        //When you create SavingsAccount objects, memory for the
        //currBalance field is allocated for each object.
        public static void AccountBal()
        {
            Console.WriteLine("***** Fun With Static Data *****\n");
            SavingsAccount s1 = new SavingsAccount(50);
            var totalAmt1 = s1.CurrBalance * CurrInterestRate + s1.CurrBalance;
            Console.WriteLine("s1: {0}, interest rate: {1}, Total Amount: {2}\n", s1.CurrBalance, CurrInterestRate, totalAmt1);
            SavingsAccount s2 = new SavingsAccount(100);
            var totalAmt2 = s2.CurrBalance * CurrInterestRate + s2.CurrBalance;
            Console.WriteLine("s2: {0}, interest rate: {1}, Total Amount: {2}\n", s2.CurrBalance, CurrInterestRate, totalAmt2);
            SavingsAccount s3 = new SavingsAccount(10000.75);
            var totalAmt3 = s3.CurrBalance * CurrInterestRate + s3.CurrBalance;
            Console.WriteLine("s3: {0}, interest rate: {1}, Total Amount: {2}", s3.CurrBalance, CurrInterestRate, totalAmt3);

            Console.ReadLine();
        }

        //static memebers to get/set interest rate
        public static void SetInterestRate(double newRate)
        {
            CurrInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return CurrInterestRate;
        }

        public static void AccountBal2()
        {
            Console.WriteLine("***** Fun with static data *****");
            SavingsAccount s1 = new SavingsAccount(50);
            SavingsAccount s2 = new SavingsAccount(100);

            //Print the current interest rate
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            //Make new object, this does NOT 'reset' the interest rate.
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            Console.ReadLine();
        }

         //if you attempted to assign the
        //value of a static point of data in a typical constructor? You might be surprised to
        //find that the value is reset each time you create a new object!
        public static void AcoountBal3()
        {
            Console.WriteLine("***** Fun with static data *****");
            //make an account
            SavingsAccount s1 = new SavingsAccount(50);
            //print the current interest rate
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            //Try to change the interest rate via the property
            SavingsAccount.SetInterestRate(0.08);
            //make a second account
            SavingsAccount s2 = new SavingsAccount(100);
            //should print 0.08... right??
            Console.WriteLine("Interest Rate is: {0}", GetInterestRate());
        }

    }
}
