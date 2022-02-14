using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter8.CustomInterface.Shapes
{
    public class Triangle_Inf : Shape_Inf, IPointy
    {
        public Triangle_Inf() { }
        public Triangle_Inf(string name)
            :base(name)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing the Triangle: {0}", PetName);
        }
        //IPoint implementation
        public byte Points
        {
            get{ return 3; }
        }
    }
}
