using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter8.CustomInterface.Shapes
{
    public class Hexagon_Inf : Shape_Inf, IPointy
    {
        

        public Hexagon_Inf() { }
        public Hexagon_Inf(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon_Inf", PetName);
        }

        public static void Hex()
        {
            Hexagon_Inf hex = new Hexagon_Inf("Beth");
            hex.Draw();
        }
        //IPoint implementation
        public byte Points
        {
            get { return 9; }
        }

        public static void CallingInterfaceProp()
        {
            Console.WriteLine("**** Fun with Interfaces ****\n");
            Hexagon_Inf hex = new Hexagon_Inf();
            Console.WriteLine("Points: {0}", hex.Points);
            Console.ReadLine();
        }
    }
}
