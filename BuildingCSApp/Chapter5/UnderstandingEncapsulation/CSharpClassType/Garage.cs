using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.CSharpClassType
{
    public class Garage
    {
        //the hidden int backing field is set to zero if no value is initialized
        //the hidden backing field is det to 1
        public int NumberOfCars { get; set; } = 1;
        //the hidden car backing field is set to null if not set to a new object
        //the hidden backing field is set to a new car object
        public CarObj MyAuto { get; set; } = new CarObj();

        //must use constructor to override default
        //values assigned to hidden backing fields.
        
        public Garage()
        {
            MyAuto = new CarObj();
            NumberOfCars = 1;
        }

        public Garage(CarObj car, int number)
        {
            MyAuto = car;
            NumberOfCars = number;
        }
        

        public static void DefaultValue()
        {
            //Make a car
            CarObj c = new CarObj();
            c.PetName = "Frank";
            c.CurrSpeed = 55;
            c.Color = "Red";
            c.DisplayStats();

            //Put car in garage
            Garage g = new Garage();
            g.MyAuto = c;

            //prints default value of zero
            Console.WriteLine("Number of cars: {0}", g.NumberOfCars);
            //runtime error! backing field is currently null! 
            Console.WriteLine("Your car name is: {0}",g.MyAuto.PetName);
            Console.WriteLine(g.MyAuto.Color);
        }
    }
}
