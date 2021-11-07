using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.BasicInheritance
{
    public class Car_Ihr
    {
        public readonly int MaxSpeed;
        private int CurrSpeed;

        public Car_Ihr(int max)
        {
            MaxSpeed = max;
        }
        public Car_Ihr()
        {
            MaxSpeed = 55;
        }
        public int Speed
        {
            get { return CurrSpeed; }
            set
            {
                CurrSpeed = value;
                if (CurrSpeed > MaxSpeed)
                {
                    CurrSpeed = MaxSpeed;
                }
            }
        }

        public static void CarProp()
        {
            Console.WriteLine("**** Basic Inheritance ****\n");
            //make a car object and set max speed
            Car_Ihr myCar = new Car_Ihr(80);
            //set current speed and print it
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
        }
    }
}
