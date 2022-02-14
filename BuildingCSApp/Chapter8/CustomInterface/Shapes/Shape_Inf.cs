using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter8.CustomInterface.Shapes
{
    public abstract class Shape_Inf
    {
        public string PetName { get; set; }
        public Shape_Inf(string name = "NoName")
        {
            PetName = name;
        }
        //A single virtual method
        /*public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }*/
        //Forces all to define how to be rendered
        public abstract void Draw();

        public static void Shape_Astract()
        {
            Console.WriteLine("**** Fun with polymorphism ****");
            // Make an array of Shape-compatible objects.
            Shape_Inf[] myShapes = { new Hexagon_Inf(), new Circle_Inf(), new Hexagon_Inf("Mick"), new Circle_Inf("Beth"), new Hexagon_Inf("Linda") };

            foreach (var s in myShapes)
            {
                s.Draw();
            }
            Console.WriteLine();
        }
    }
}
