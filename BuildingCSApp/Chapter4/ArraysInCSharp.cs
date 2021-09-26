using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter4
{
    public class ArraysInCSharp
    {
        public static void SimpleArrays()
        {
            //create an array of int containing 3 elements indexed 0,1,2
            int[] myInt = new int[3] { 200, 300, 400};

            //create a 3 item string array  indexed 0-99
            string[] booksOnDotnet = new string[3];

            myInt[0] = 100;
            myInt[1] = 200;
            myInt[2] = 300;

            foreach (var i in myInt)
                Console.WriteLine(i);
            Console.WriteLine();

            int[] newInt = { 300, 400, 500, 600 };
            foreach (var j in newInt)
                Console.WriteLine(j);
            Console.WriteLine();

            string[] undefinedNumberOfElements = { };
            undefinedNumberOfElements = new[] { "ANNA", "GABRIEL", "SOMTOCHUKWU", "BASIL", "EDMUND" };
            //must be same number of elements declared above
            booksOnDotnet[0] = "Docker";
            booksOnDotnet[1] = "Kubernete";
            booksOnDotnet[2] = "Microservices";

            foreach (var b in booksOnDotnet)
                Console.WriteLine(b);
            Console.WriteLine();

            //can be any number element
            string[] newBooksOnDotnet = { "Advance CSharp", "Internet Of Things", "Respository Architecture", "MySql", "SqlServer" };
            foreach (var nb in newBooksOnDotnet)
                Console.WriteLine(nb);
            Console.WriteLine();
          
        }

        public static void DeclareImplicitArray()
        {
            Console.WriteLine("=> Implicit Array Initialization");
            //a is really int[]
            var a = new[] { 1, 2, 3, 4 };
            Console.WriteLine("a is a: {0}", a.ToString());

            //b is really double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            //c is really string[]
            var c = new[] { "hello", "null", "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
        }

        public static void ArrayOfObject()
        {
            Console.WriteLine("=> Array of Objects");
            //An array of Object can be anything at all
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1993, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (var obj in myObjects)
                //print the type and value for each item in array
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            Console.WriteLine();

            object[] newObject = { "Hello World", true, 100, DateTime.Now, 120.04m };

            foreach (var newObj in newObject)
                Console.WriteLine("Type: {0}, Value: {1}", newObj.GetType(), newObj);
        }

        public static void RectangularMultiDimensionalArray()
        {
            Console.WriteLine("=> Rectangular Multidimensional array.");
            //a rectangular multidimensional array 
            int[,] myMatrix;
            //int i=6;
            //int j=5;
            //int[,] anotherMatrix;
            //anotherMatrix = new int[i, j];
            myMatrix = new int[3, 4];

            //populate (3*4) array
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;
            //print (3*4) array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged Multidimensional Array");
            // A jagged MultiDimensional array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJaggedArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJaggedArray.Length; i++)
                myJaggedArray[i] = new int[i + 7];

            // Print each row (remember, each element is
            //defaulted to zero!).
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                    Console.Write(myJaggedArray[i][j] + "");
                Console.WriteLine();
            }
        }
        //array as parameter
        public static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }
        }

        //array as return type
        public static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "From", "GetStringArray" };

            return theStrings;
        }

        //invoking the above methods
        public static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values");
            //pass array as parameter
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            //Get array as return value
            string[] strs = GetStringArray();
            foreach(string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        //static members of the array class
        public static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array");
            //initialize items at start
            string[] gothicBand = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            //print out names in declared order
            Console.WriteLine("=> Here is the Array:");
            for (int i = 0; i < gothicBand.Length; i++)
            {
                //print a name
                Console.Write(gothicBand[i] + ", ");
            }
            Console.WriteLine("\n");

            //Reverse them...
            Array.Reverse(gothicBand);
            Console.WriteLine("=> The reversed array");

            //... and print them
            for (int i = 0; i < gothicBand.Length; i++)
            {
                //print a name
                Console.Write(gothicBand[i] + ", ");
            }
            Console.WriteLine("\n");
            //clear all but the first member
            Console.WriteLine("=> cleared out all but one...");
            Array.Clear(gothicBand, 1, 2);

            for (int i = 0; i < gothicBand.Length; i++)
            {
                //print a name.
                Console.Write(gothicBand[i] + ", ");
            }
            Console.WriteLine();
        }
    }

    
    
    //Array of objects
    public class Car
    {
        public string Make;
        public string Model;
        public string Color;
        public string Speed;

    }

    public class MakeCars
    {
        //public Car[] GetCars()
        public static void GetCars()
        {
            var bmw1 = new Car
            {
                Make = "BMW",
                Model = "2015",
                Color = "Black",
                Speed = "70km/hr"
            };
            var bmw2 = new Car
            {
                Make = "BMW",
                Model = "2016",
                Color = "Blue",
                Speed = "80km/hr"
            };
            var bmw3 = new Car
            {
                Make = "BMW",
                Model = "2017",
                Color = "White",
                Speed = "90km/hr"
            };
            var bmw4 = new Car
            {
                Make = "BMW",
                Model = "2020",
                Color = "Gray",
                Speed = "95km/hr"
            };
            Car[] cars = new Car[] { bmw1, bmw2, bmw3, bmw4};

            foreach (var c in cars)
            {
                Console.WriteLine("Make: {0}\nModel: {1}\nColor: {2}\nSpeed: {3}\n--------------", c.Make, c.Model, c.Color, c.Speed);
            }

            //return cars;
        }
    }
    
}
