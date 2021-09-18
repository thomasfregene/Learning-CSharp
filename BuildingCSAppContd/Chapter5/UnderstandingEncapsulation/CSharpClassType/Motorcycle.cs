using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter5.UnderstandingEncapsulation.CSharpClassType
{
    public class Motorcycle
    {
        //field data
        public int DriverIntensity;


        public void PopAWheely()
        {
            //Console.WriteLine("Yeeeeeee Haaaaaeeww!");

            for (int i = 0; i <= DriverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeeww!");
            }
        }

        //You ARE Able to create an instance of the Motorcycle class
        //out of the box via the default constructor

        public static void DefaultConstructorInAction()
        {
            Console.WriteLine("***** Fun With Class types *****\n");
            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();
        }
        
        public static void CustomConstructorInAction()
        {
            Console.WriteLine("***** Fun With Class types *****\n");
            Motorcycle mc = new Motorcycle(4);
            mc.PopAWheely();

            Console.ReadLine();
        }

        //put vack the default constructor, which will set
        //all data members to default values
        public Motorcycle() { }

        //a custom constructor
        public Motorcycle(int intensity)
        {
            DriverIntensity = intensity;
        }
        
    }
}
