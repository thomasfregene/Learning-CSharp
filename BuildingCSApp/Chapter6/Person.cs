using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6
{
    public class Person
    {
        public  string FirstName { get; set; } = "";
        public  string Lastname { get; set; } = "";
        public  int Age { get; set; }
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            Lastname = lName;
            Age = personAge;
        }
        public Person() { }
        public static void SystemObjectMethod()
        {
            Console.WriteLine("*** Fun with System.Object ***\n");
            Person p1 = new Person();
            //Use inherited members of the System.Object
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash Code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());
            //Some other reference to p1
            Person p2 = p1;
            object o = p2;
            //Are the reference pointing to the same object in memory?
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same Instance");
            }
            Console.WriteLine();
            

        }

        public override  string ToString()
        {
            string dataState;
            dataState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirstName, Lastname, Age);
            Console.WriteLine(dataState);
            return dataState;
        }
    }
}
