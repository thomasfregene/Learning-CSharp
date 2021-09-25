using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter4.ValueAndReferenceType
{
    public struct Point1
    {
        public int X;
        public int Y;

        //A custom constructor
        public Point1(int XPos, int YPos)
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

        //assigning two intrinsic value types result in
        //two independent variables on the stack
        public static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");
            Point1 p1 = new Point1(10, 10);
            Point1 p2 = p1;

            //print both points
            p1.Display();
            p2.Display();

            //change p1.X and print again. p2.X is not changed
            p1.X = 100;
            Console.WriteLine("\n=> changed p1.X\n");
            p1.Display();
            p2.Display();
        }
        
    }
}
