using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter4.ValueAndReferenceType
{
    public class PointRef
    {
        public int X;
        public int Y;

        //A custom constructor
        public PointRef(int XPos, int YPos)
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

        public static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            //print both point refs
            p1.Display();
            p2.Display();

            //change p1.X and print again
            p2.X = 100;
            Console.WriteLine("\n=> changed p1.X\n");
            p1.Display();
            p2.Display();
        }
    }
}
