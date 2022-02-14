using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter8.ICloneableExample
{
    public class CloneableIntefaceExample
    {
        public static void ExampleMethod()
        {
            Console.WriteLine("***** A First Look at Interfaces *****");
            //All of this classes support the ICloneable interface.
            string myStr = "Hello";
            OperatingSystem WOS = new OperatingSystem(PlatformID.MacOSX, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();
            //Therefore they can all be passed into a method taking ICloneable
            CloneMe(myStr);
            CloneMe(WOS);
            CloneMe(sqlCnn);
            Console.ReadLine();
            Console.WriteLine("Operating System: {0}", WOS);

        }

        private static void CloneMe(ICloneable c)
        {
            //clone whatever we get and print out the name
            object theClone = c.Clone();
            Console.WriteLine("Your clone is: {0}", theClone.GetType().Name);
        }
    }
}
