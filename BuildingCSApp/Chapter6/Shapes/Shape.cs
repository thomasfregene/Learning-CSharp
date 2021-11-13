using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.Shapes
{
    //The abstract base class of the hierarchy
    public abstract class Shape
    {
        public string PetName { get; set; }
        public Shape(string name = "NoName")
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
            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };

            foreach (var s in myShapes)
            {
                s.Draw();
            }
            Console.WriteLine();
        }
    }
}
