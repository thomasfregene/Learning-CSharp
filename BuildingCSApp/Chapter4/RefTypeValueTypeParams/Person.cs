using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter4.RefTypeValueTypeParams
{
    public class Person
    {
        public string PersonName;
        public int PersonAge;

        //Constructors
        public Person(string name, int age)
        {
            PersonName = name;
            PersonAge = age;
        }
        public Person()
        {

        }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", PersonName, PersonAge);
        }

        //method allowing caller to send person object by value
        public static void SendAPersonByValue(Person p)
        {
            //change the age of "p"
            p.PersonAge = 99;
            //will the caller see this reassignment?
            p = new Person("Nikki", 99);
        }

        public static void PassingRefTypeByValue()
        {
            Console.WriteLine("***** Passing Person Object by value *****");

            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call Person is:");
            fred.Display();

            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call Person is:");
            fred.Display();
            Console.ReadLine();
        }

        public static void SendAPersonByReference(ref Person p)
        {
            //cange some data of p
            p.PersonAge = 555;
            //"p" is now pointing to a new object on the heap!
            p = new Person("Nikki", 999);
        }

        public static void PassingRefTypesByRef()
        {
            Console.WriteLine("**** Passing Person object by reference type");

            Person mel = new Person("Mel", 23);
            Console.WriteLine("Before by ref call Person is:");
            mel.Display();

            SendAPersonByReference(ref mel);
            Console.WriteLine("After by ref call Person is:");
            mel.Display();
            Console.ReadLine();
        }
        
    }
}
