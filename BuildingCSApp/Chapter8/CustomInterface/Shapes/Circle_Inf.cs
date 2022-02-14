using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter8.CustomInterface.Shapes
{
    public class Circle_Inf : Shape_Inf
    {
        public Circle_Inf() { }
        public Circle_Inf(string name) : base(name) { }

        public static void Cir()
        {
            Circle_Inf cir = new Circle_Inf("Cindy");
            cir.Draw();
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle_Inf", PetName);
        }
    }
}
