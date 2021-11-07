using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.Employees
{
    public class Manager_Ihr : Employee_Ihr
    {
        public int StockOptions { get; set; }
        /*public Manager_Ihr(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
        {
            //this property is defined by the manager class
            StockOptions = numbOfOpts;
            //Assign incoming parameters using the
            //inherited properties of the parent class
            Id = empID;
            Age = age;
            Name = fullName;
            Pay = currPay;
            //This would be a compiler error, if 
            //the SSN property were readonly
            //SocialSecurityNumber = ssn;
        }*/

        public Manager_Ihr(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
          
        }
        //default ctor
        public Manager_Ihr() { }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }

        public static void Employee_Manager()
        {
            Manager_Ihr chucky = new Manager_Ihr("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(200);
            chucky.DisplayStats();
            Console.WriteLine();
        }
    }
}
