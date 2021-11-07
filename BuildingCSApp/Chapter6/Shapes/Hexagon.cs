using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.Shapes
{
    public class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        public static void Hex()
        {
            Hexagon hex = new Hexagon("Beth");
            hex.Draw();
        }
    }
}
