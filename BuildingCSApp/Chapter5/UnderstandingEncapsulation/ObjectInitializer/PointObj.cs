using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.ObjectInitializer
{
    public class PointObj
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public PointObj()
        :this(PointColor.BloodRed){ }
        public PointObj(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }
        public PointObj(PointColor ptColor)
        {
            Color = ptColor;
        }
        public void DisplayStats()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Point is: {0}", Color);
        }

        public static void ObjInitializerSyntax()
        {
            Console.WriteLine("***** Fun with Object Initializer Syntax *****\n");
            //Make a Point by setting each property manually
            PointObj firstPoint = new PointObj();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            Console.WriteLine("First Point");
            firstPoint.DisplayStats();

            //Or make a point via custom constructor
            PointObj anotherPoint = new PointObj(20, 20);
            Console.WriteLine("Another Point");
            anotherPoint.DisplayStats();

            //Or make a Point using Obj Init syntax
            PointObj finalPoint = new PointObj
            {
                X = 30,
                Y = 30
            };
            Console.WriteLine("Final Point");
            finalPoint.DisplayStats();

            //with initializer syntax you are able to invoke any
            //constructor defined by the class
            PointObj pt = new PointObj(10, 16) { X = 100, Y = 100 };
            Console.WriteLine("PT Point");
            pt.DisplayStats();

            //Call a more interesting custom constructor with init syntax
            PointObj goldPoint = new PointObj(PointColor.Gold) { X = 90, Y = 20 };
            Console.WriteLine("Gold Point");
            goldPoint.DisplayStats();
        }
    }
}
