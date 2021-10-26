using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.ConstData
{
    public class MyMathClass
    {
        public const double PI = 3.14;
        //read only field
        public readonly double Pi;
        //static read ony field almost similar to const data
        public static readonly double pI= 3.14;
        //if static readonly field's value is not 
        //known until runtime use static ctor
        static MyMathClass()
        {
            pI = 3.14;
        }

        public MyMathClass()
        {
            Pi = 3.142;
        }

        //Error!
        /*public void ChangePi()
        {
            Pi = 3.142;
        }*/
        public static void UsingConstData()
        {
            Console.WriteLine("***** Fun with Const *****\n");
            Console.WriteLine("The value of PI is: {0}", MyMathClass.PI);
            //Error! can't change a constant value
            //MyMathClass.PI = 3.1444;
        }

        //constant variable is also possible
        public static void LocalConstStringVariable()
        {
            //A local constant data point can be directly accessed
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);

            //Error!
            //fixedStr = "This will not work";
        }
    }
}
