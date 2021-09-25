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
        public string DriverName;

        //constructor chain
       /* public Motorcycle() { Console.WriteLine("In default ctor"); }
        public Motorcycle(int intensity)
           : this(intensity, "") { Console.WriteLine("in ctor taking an int"); }
        public Motorcycle(string name)
            : this(0, name) { Console.WriteLine("in ctor taking a string"); }
        //This is the naster constructor that does all the real work
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("in master ctor");
            if (intensity > 10)
            {
                intensity = 10;
            }
            DriverIntensity = intensity;
            DriverName = name;
        }*/


        //a single constructor using optional parameter
        public Motorcycle(int intensity=0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            DriverIntensity = intensity;
            DriverName = name;
        }
      
        public void PopAWheely()
        {
            //Console.WriteLine("Yeeeeeee Haaaaaeeww!");

            for (int i = 0; i <= DriverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeeww!");
            }
            Console.ReadLine();
        }

        private void SetDriverName(string name)
        {
            DriverName = name;
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

        public static void ChainingConstructors()
        {
            Console.WriteLine("***** Fun With Class types *****\n");

            Motorcycle mc1 = new Motorcycle()
            {
                DriverIntensity = 20,
                DriverName = "Don"
            };

            mc1.PopAWheely();

            Motorcycle mc2 = new Motorcycle(75);
            mc2.PopAWheely();

            Motorcycle mc3 = new Motorcycle(name:"Joe");
            mc3.PopAWheely();

            Motorcycle mc4 = new Motorcycle(20, "Von");
            mc4.PopAWheely();

        }

        public static void CtorFlow()
        {
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();

            Console.WriteLine("driver name is: {0}", c.DriverName);
        }


        public static void MakeSomeBikes()
        {
            Motorcycle ml = new Motorcycle();
            Console.WriteLine("Name: {0}, Intensity: {1}\n", ml.DriverName, ml.DriverIntensity);

            Motorcycle ms = new Motorcycle(name: "Tiny");
            Console.WriteLine("Name: {0}, Intensity: {1}\n",ms.DriverName, ms.DriverIntensity);

            Motorcycle mc = new Motorcycle(7);
            Console.WriteLine("Name: {0}, Intensity: {1}\n", mc.DriverName, mc.DriverIntensity);

            Motorcycle mm = new Motorcycle(11, "Morrison");
            Console.WriteLine("Name: {0}, Intensity: {1}", mm.DriverName, mm.DriverIntensity);

        }
      
        //put pack the default constructor, which will set
        //all data members to default values
        /*public Motorcycle() { }

        //a custom constructor
        public Motorcycle(int intensity)
        {
            DriverIntensity = intensity;
        }*/

    }
}
