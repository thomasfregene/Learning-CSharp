using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter4.FunWithStrucures
{
    public struct Point
    {
        //fields of the structure
        public int X;
        public int Y;

        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        //Add 1 to the (X,Y) position
        public void Increment()
        {
            X++; Y++;
        }
        //substract 1 from the (X,Y) position
        public void Decrement()
        {
            X--; Y--;
        }
        //Display the current position
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

        public static void UseOfStruct()
        {
            //create an initial point
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            //Adjust the X and Y values
            myPoint.Increment();
            myPoint.Display();
            Console.ReadLine();

            myPoint.Decrement();
            myPoint.Decrement();
            myPoint.Display();

           /*NB: if you donot assign each piece of public field
            data(X and Y in this case) before using the structure, 
           you will receive a compiler error*/
        }
    }
}
