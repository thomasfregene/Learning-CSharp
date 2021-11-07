using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.Shapes
{
    public class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public static void Cir()
        {
            Circle cir = new Circle("Cindy");
            cir.Draw();
        }
    }
}
