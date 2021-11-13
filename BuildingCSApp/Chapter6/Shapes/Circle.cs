using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.Shapes
{
    // If we did not implement the abstract Draw() method, Circle would also be
    // considered abstract, and would have to be marked abstract!


    public class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public static void Cir()
        {
            Circle cir = new Circle("Cindy");
            cir.Draw();
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the circle", PetName);
        }
    }
}
