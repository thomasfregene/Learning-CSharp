using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter4.FunWithStrucures
{
    public class ClassPoint
    {
        public int X;
        public int Y;

        public void Increment()
        {
            X++; Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

        public static void Result()
        {
            Point myPoint;
            myPoint.X = 345;
            myPoint.Y = 45;
            myPoint.Display();

            myPoint.Increment();
            myPoint.Display();
        }
    }
}
