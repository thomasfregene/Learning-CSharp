using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter2
{
    public static class IterationConstructs
    {
        /// <summary>
        /// when you need to iterate over a block of code a fixed number of times, 
        /// the for statement provides a goo ideal of flexibility.
        /// in essence you are able to specify how many times a block of code repeats itself
        /// </summary>
        public static void ForLoopExample()
        {
            int f=100; 

            int j;
            for (int i = 1; i < 100; i++)
            {
                j = f * ( f -= i * f);
                //j = i * (i - 1);
                Console.WriteLine("Factorial of {0} is {1}",i, j);
            }
        }

        /// <summary>
        /// the foreach keyword allows you to iterate over all items in a container
        /// without the need to test for an upper limit. 
        /// Unlike a for loop, however the forech loop will walk the container only
        /// in a linear(n+1) fashion(thus you cannot go back through the container, skip every third element etc)
        /// </summary>
        public static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda", };
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }

            int[] myInts = { 10, 20, 30, 40, 50 };
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        public static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            var subset = numbers.Where(i => i < 10).Select(i => i);
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
        }

        /// <summary>
        /// the while looping construct is useful should you want to execute 
        /// a block of statement until some terminating event is indeed established
        /// otherwise you will be suck in an endless loop
        /// </summary>

        public static void WhileLoopExample()
        {
            string userIsDone = "";
            while (!userIsDone.ToLower().Equals("yes"))
            {
                Console.WriteLine("In While loop");
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();

                if (!(userIsDone.ToLower().Equals("yes") || userIsDone.ToLower().Equals("no")))
                {
                    Console.WriteLine("invalid response... be like say you no get sense...");
                }
            }
        }

        /// <summary>
        /// closely related to the while loop is the do/while statement
        /// Like a simple while loop, do/while is used when you need
        /// to perform some action an undetermined number of times
        /// the difference is that do/while loops are guaranteed to execute 
        /// the corresponding block of code atleast once. In constrast
        /// it is possible that a simple while loop may never execute if the 
        /// terminating condition is false from the onset
        /// </summary>

        public static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In Do/While loop");
                Console.WriteLine("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (!userIsDone.ToLower().Equals("yes"));
        }

        public static void SwitchExample()
        {
            Console.WriteLine("1 [C#], 2 [VB], 3 [JS]");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                case 3:
                    Console.WriteLine("Javascript JS for short is a functional programming language");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that");
                    break;
            }
        }

        public static void SwitchOnStringExample()
        {
            Console.WriteLine("C#, VB or JS");
            Console.Write("Please pick your language preference: ");
            string langChoice = Console.ReadLine().ToUpper();

            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                case "JS":
                    Console.WriteLine("Javascript JS for short is a functional programming language");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that");
                    break;
            }
        }
        public static void SwitchOnEnumExamples()
        {
            Console.Write("Enter your favorite day of the week");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad Input!");
                return;
                throw;
            }
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day another dollar");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost friday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed");
                    break;
                default:
                    break;
            }
        }
    }
}
