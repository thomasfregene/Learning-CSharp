using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.BasicInheritance
{
    public class MiniVan : Car_Ihr
    {
        public static void Car_MiniVan()
        {
            
            Console.WriteLine("**** Basic Inheritance ****\n");
            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My van is going {0} MPH", myVan.Speed);
            
        }
    }
}
