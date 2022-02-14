using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter8.CustomInterface.Shapes
{
    //This class extends circle and hides the inherited Draw() method
    public class ThreeDCircle_Inf : Circle_Inf
    {
        //Hides the PetName property of inherited class
        public new string PetName { get; set; }
        //Hides the inherited Draw() method
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D circle");
        }

        public static void ThreeDCircle_Status()
        {
            ThreeDCircle_Inf o = new ThreeDCircle_Inf();
            // This calls the Draw() method of the ThreeDCircle.
            o.Draw();
            // This calls the Draw() method of the parent!
            ((Circle_Inf)o).Draw();
        }
    }
}
