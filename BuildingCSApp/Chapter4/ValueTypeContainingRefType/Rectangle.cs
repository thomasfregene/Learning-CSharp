using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter4.ValueTypeContainingRefType
{
    public struct Rectangle
    {
        //the rectangle structure contains a reference member
        public ShapeInfo rectInfo;
        public int rectTop, rectLeft, rectBottom, rectRight;
        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top; rectBottom = bottom;
            rectLeft = left; rectRight = right;
        }

        public void Display()
        {
            Console.WriteLine(@"String = {0}, Top = {1}, Bottom = {2}, Left = {3}
            Right = {4}", rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }

        public static void ValueTypeContainingRefType()
        {
            //Create the first rectangle
            Console.WriteLine("->Create r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            //now assign a new rectangle to r1
            Console.WriteLine("=>Assign r2 to r1");
            Rectangle r2 = r1;

            //change some values of r2
            Console.WriteLine("changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;

            //print values of bottom rectangle
            r1.Display();
            r2.Display();
        }
        
    }
}
