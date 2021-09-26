using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class SystemString
    {
        public static void EscapeCharacters()
        {
            Console.WriteLine("=>Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPetName\a";
            Console.WriteLine("strWithTab:{0}", strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\Bin\\Debug\a ");
            //Adds a total of four blank lines and then beeps again
            Console.WriteLine("All finished.\n\n\n\n\a ");
        }

        public static void VerbatimString()
        {
            //white space is preserved with verbatim strings
            string myLongString = @"This is a very 
            very
                    very
                            Long String";
            Console.WriteLine(myLongString);

            //you can also insert ""
            Console.WriteLine(@"Cerebus said ""Darr! Pret-ty sun-set""");
        }

        public static void StringEquality()
        {
            /*The equality operator have being redefined to compare the values of string object,
             not the object in memory to which they refer, i.e
            The c# equality operator performs a case-sensitive, character-by-chararcter 
            equality test on strng objects*/
            Console.WriteLine("=>String equality");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("string s1={0}", s1);
            Console.WriteLine("string s2={0}", s2);
            Console.WriteLine();
            //testing for equality
            Console.WriteLine("s1==s2: {0}", s1==s2 );
            Console.WriteLine("s1== Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1== HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1== hello!: {0}", s1 == "hello!");

            Console.WriteLine("s1.Equals(s1): {0}", s1.Equals(s2));
            Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));

        }

        public static void BasicStringManipulation()
        {
            Console.WriteLine("=> Basic string functionality");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("fistName has {0} characters", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y: {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replacement: {0}", firstName.Replace("dy", ""));
        }

        public static void StringsAreImmutable()
        {
            /*one of the interesting aspects of System.String is that after you assign a string object
             with its initial value "the caharacter data 'cannot be changed' "*/

            string s1 = "This is my string.";
            Console.WriteLine("s1: {0}", s1);
            //UpperCase s1
            string upperString = s1.ToUpper();
            //returns a copy of s1 in modifed format.
            Console.WriteLine("upperString= {0}", upperString);

            //s1 is stll in the same format
            Console.WriteLine("s1= {0}", s1);

            //int i = 2;
            //int newI = i = 3;
            //Console.WriteLine(newI);
        }

        public static void StringInterpolation()
        {
            int age = 4;
            string name = "Soren";
            //using curly bracket syntax
            string greetings = string.Format("Hello {0}, you are {1} years old", name, age);
            Console.WriteLine("=> using curly bracket syntax");
            Console.WriteLine(greetings);

            //using string interpolation 
            /*the curly bracket used in string interpolation are valid scope
             there the dot operator can be used on the variables to change their state*/
            string greetings2 = $"Hello {name.Replace("o", "e")}, you are {age} years old";
            Console.WriteLine("=> using string interpolation");
            Console.WriteLine(greetings2);


            
        }
    }
}
