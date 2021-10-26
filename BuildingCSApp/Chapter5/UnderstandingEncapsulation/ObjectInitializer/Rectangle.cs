using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.ObjectInitializer
{
    public class Rectangle
    {
        private PointObj topLeft = new PointObj();
        private PointObj bottomRight = new PointObj();

        public PointObj TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        public PointObj BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]", topLeft.X, topLeft.Y, topLeft.Color,
                bottomRight.X, bottomRight.Y, bottomRight.Color);
        }

        public static void ObjInitRect()
        {
            //Create and initialize a Rectangle
            Rectangle myRect = new Rectangle
            {
                TopLeft = new PointObj { X = 10, Y = 10 },
                BottomRight = new PointObj { X = 200, Y = 200 }
            };
            myRect.DisplayStats();

            //Old-school approach
            Rectangle r = new Rectangle();
            PointObj p1 = new PointObj();
            p1.X = 10;
            p1.Y = 10;
            r.TopLeft = p1;
            PointObj p2 = new PointObj();
            p2.X = 200;
            p2.Y = 200;
            r.BottomRight = p2;
        }
      

    }
}
