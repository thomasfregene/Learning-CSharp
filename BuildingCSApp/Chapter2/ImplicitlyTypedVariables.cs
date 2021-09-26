using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class ImplicitlyTypedVariables
    {
        public static void DeclareExplicitVariables()
        {
            /*Explicitly typed local variables are declared as follows
             dataType variableName = initialValue*/
            int myInt = 0;
            bool myBool = true;
            string myString = "TIME marches on...";

            Console.WriteLine($"myInt = {myInt},\nmyBool = {myBool} and \nmyString = {myString}\n\n");
        }

        public static void DeclareImplicitVariables()
        {
            /*Implcitly typed local variables are declared as follows
            var variableName = initialValue*/
            var myInt = 0;
            var myBool = true;
            var myString = "TIME marches on...";

            //print out all underlying types
            Console.WriteLine("myInt is a: {0}, \nmyBool is a: {1}, \nmyString is a:{2}", 
                myInt.GetType().Name, myBool.GetType().Name, myString.GetType().Name);
        }

        public static void LinqQueryOverInt()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            //linq query
            var subset = from i in numbers where i < 10 select i;

            Console.WriteLine("values in subset ");
            foreach (var i in subset)
            {
                Console.WriteLine("{0} ", i);
            }

            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
    }
}
