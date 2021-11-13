using BuildingCSApp.Chapter6.Employees;
using BuildingCSApp.Chapter6.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6
{
    public class AsKeyword
    {
        //Use "as" to test compatibility
        public static void UsingAsKeyword()
        {
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager_Ihr();
            things[3] = "Last Thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                    Console.WriteLine("Item is not hexagon");
                else
                    h.Draw();
            }
        }

    }
}
