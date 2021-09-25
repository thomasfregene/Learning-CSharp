using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSAppContd.Chapter4
{
    public static class MethodsAndParameterModifiers
    {
        ///
        /// the default manner in which a parameter is sent into 
        /// a function is by value
        ///
        public static int Add(int x, int y)
        {
            int ans = x + y;
            //caller will not see this changes as you are 
            //modifying a copy of the original data.
            x = 1000;
            y = 8888;
            Console.WriteLine(ans);
            return ans;
        }

        public static void ValueTypeParams()
        {
            Console.WriteLine("*****Fun with methods*****\n");
            //pass two variable in by value
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);

            Console.WriteLine("Answer is: {0}", Add(x, y));

            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

            Console.ReadLine();
        }
        /// <summary>
        /// out modifier
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="ans"></param>
        public static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        public static void OutParams()
        {
            /*No need to assign initial value to local variables
             used as output parameters, provided the first time 
            you use them is as output arguments*/
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}", ans);
        }

        public static void FillTheValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        public static void InvokingMtdFillTheValues()
        {
            int i; string str; bool b;
            FillTheValues(out i, out str, out b);
            Console.WriteLine("Int i: {0}", i);
            Console.WriteLine("String str: {0}", str);
            Console.WriteLine("bool b: {0}", b);
        }

        public static void Response(out int code, out string msg, out string status)
        {
            code = 404;
            msg = "Not Found";
            status = "Request Failed";

        }

        public static void InvokinResponseMethod()
        {
            int code; string msg; string status;
            Response(out code, out msg, out status);

            Console.WriteLine("Response Code: {0}", code);
            Console.WriteLine("Response Message: {0}", msg);
            Console.WriteLine("Response Status: {0}", status);
        }

        /*public static void ThisWontCompile(out int a)
        {
            Console.WriteLine("Error the output parameter a must be assigned");
        }*/

        /// <summary>
        /// Ref Modifier
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        public static void InvokingSwapStringsMtd()
        {
            Console.WriteLine("**** Fun With Methods ****");
            string s1 = "Flip";
            string s2 = "Flop";
            Console.WriteLine("Before: {0}, {1}", s1, s2);
            SwapStrings(ref s1, ref s2);
            Console.WriteLine("After: {0}, {1}", s1, s2);
        }
        /// <summary>
        /// params Modifier
        /// .length means the number of element 
        /// in an array...
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public static double CalculateAverage(params double[] values)
        {
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
            //return sum;
           
        }
        ///the above method have been defined to 
        ///take  a parameter array of doubles(including zero)
        ///and compute the average... Given this
        ///you can call average in any of the following ways:
        public static void InvokingCalculateAverageMtd()
        {
            Console.WriteLine("**** Fun With Methods ****");

            //passing a comma de-limited list of doubles..
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);

            //or pass an array of doubles
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);

            //average of 0 is 0
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
        }

        ///Named Paramaters
        ///named arguments allow you to invoke a method by specifying 
        ///parameter values in any order you choose
        public static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            //store old colors to restore after message is printed
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            //set new colors and print message
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            //restore previous color
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }

        public static void InvokingDisplayFancyMessage()
        {
            Console.WriteLine("****Fun With Methods****");
            DisplayFancyMessage(message: "WOW! very fancy indeed", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);

            DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);

            Console.ReadLine();
        }

        /*Note: the value assigned to an optional
        parameter must be known at compile time and cannot be resolved at runtime
            */
        public static void OptionalParameter(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }
        /*DateTime tipeStamp = DateTime.Now this will not compile because
           the value of the Now property of the
            DateTime class is resolved at runtime, not compile time.
            */
        public static void OptionalParameter(string message, DateTime timeStamp, string owner = "Programmer"/*, DateTime tipeStamp = DateTime.Now*/)
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
            Console.WriteLine("Time of Error: {0}", timeStamp);
        }

        public static void InvokingOptionalParameter()
        {
            OptionalParameter("Oh no! Grid can't find data");
            OptionalParameter("Oh no! i can't find the payroll data", "CFO");
            Console.WriteLine("---------------------------------------------");
            OptionalParameter("Oh no! I can't find the payroll data", DateTime.Now);
        }
        
    }
}
