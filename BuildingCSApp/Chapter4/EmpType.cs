using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter4
{
    /// <summary>
    /// The EmpType enumeration defines four named constants, corresponding to
    ///discrete numerical values.By default, the first element is set to the value zero
   ///(0), followed by an n+1 progression.
   /// </summary>
    public enum EmpType
    {
        Manager,
        Grunt,
        Contractor,
        VicePresident
    }
    /// <summary>
    /// You are free to change the initial value as
    //you see fit.For example, if it made sense to number the members of EmpType as
    ///102 through 105, you could do so as follows:
    /// </summary>
    enum EmpType1
    {
        Manager = 102,
        Grunt, //=103
        Contractor, //=104
        VicePresident //=105
    }

    /// <summary>
    /// Enumerations do not necessarily need to follow a sequential ordering and do
    /// not need to have unique values. If (for some reason or another) it makes sense to
    /// establish your EmpType as shown here, the compiler continues to be happy:
    /// </summary>
    enum EmpType2
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100, 
        VicePresident = 9
    }

    ///By default, the storage type used to hold the values of an enumeration is a
    ///System.Int32 (the C# int); however, you are free to change this to your liking
    ///
    enum EmpType3 : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    public class Bonus
    {
        public static void BonusRequest()
        {
            Console.WriteLine("***Fun With Enums***");
            //make an EmpType variable
            EmpType emp = EmpType.Contractor;

            AskForBonus(emp);

            Console.WriteLine("------using GetType()---------");
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("-----using typeof-------");
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpType)));
            //prints out the string of enum and its number value
            Console.WriteLine("-----uisng ToString()------------");
            Console.WriteLine("{0} = {1}", emp.ToString(), (int)emp);

            Console.ReadLine();
        }

        private static void AskForBonus(EmpType emp)
        {
            
            switch (emp)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already got enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Very Good, Sir!");
                    break;
                default:
                    break;
            }
        }

        //this method will print out the details of any enum
        public static void EvaluateEnum(System.Enum _enum)
        {
            Console.WriteLine("Information about {0}", _enum.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(_enum.GetType()));

            //Get all name/value pairs for incoming parameter.
            Array enumData = Enum.GetValues(_enum.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            //Now show the string name and associated value, using the D format (flag)
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
