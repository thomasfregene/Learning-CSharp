using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.CSharpClassType
{
    public class CarObj
    {
        //the 'state' of the car
       /* public string PetName;
        public int CurrSpeed;*/

        //using automatic property
        public string PetName { get; set; }
        public int CurrSpeed { get; set; }
        public string Color { get; set; }


        //A custom default constructor
        public CarObj()
        {
            PetName = "Chuck";
            CurrSpeed = 10;
        }

        //Here currSpeed will receive the default value of int (zero)
        public CarObj(string pn)
        {
            PetName = pn;
        }

        //Let caller set the ful state of the car
        public CarObj(string pn, int cs)
        {
            PetName = pn;
            CurrSpeed = cs;
        }


        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", CurrSpeed);
            Console.WriteLine("Color: {0}", Color);
        }
        //the functionality of the car
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH", PetName, CurrSpeed);
        }

        public void SpeedUp(int delta)
        {
            CurrSpeed += delta;
        }
         
        public static void CurrentState()
        {
            Console.WriteLine("**** Fun with Class types ****\n");
            //Allocate and configure a car object

             CarObj myCar = new CarObj();
             myCar.PetName = "Henry";
             myCar.CurrSpeed = 10;

             for (int i = 0; i < 10; i++)
             {
                 myCar.SpeedUp(5);
                 myCar.PrintState();
             }
                Console.WriteLine("\n");
            Console.WriteLine("Default constructor values\n");

            //uses 0default constructor value
            CarObj chuck = new CarObj();
            chuck.PrintState();
        }

        public static void UsingConstructorOverLoad()
        {
            CarObj chuck = new CarObj();
            chuck.PrintState();

            CarObj mary = new CarObj("Mary");
            mary.PrintState();

            CarObj daisy = new CarObj("Daisy", 75);
            daisy.PrintState();
        }

        public static void UsingAutomaticProp()
        {
            Console.WriteLine("***** Fun with Automatic Property *****");
            CarObj c = new CarObj();
            c.PetName = "Frank";
            c.CurrSpeed = 55;
            c.Color = "Red";

            Console.WriteLine("Your car is named {0}? That's odd...", c.PetName);
            c.DisplayStats();
        }
    }
}
