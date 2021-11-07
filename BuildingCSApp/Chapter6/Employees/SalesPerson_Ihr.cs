using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.Employees
{
    public class SalesPerson_Ihr : Employee_Ihr
    {
        public int SalesNumber { get; set; }

        public SalesPerson_Ihr(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
        //default ctor
        public SalesPerson_Ihr() { }

        // A salesperson’s bonus is influenced by the
        //number of sales.
        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
           
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
        }
        public static void Employee_SalesPerson()
        {
            Console.WriteLine("**** The Employee Class Hierarchy ****\n");
            SalesPerson_Ihr fred = new SalesPerson_Ihr();
            //first two properties were inherited from parent class Employee_Ihr
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

        }

        public static void EmployeeSalesPerson()
        {
            SalesPerson_Ihr fran = new SalesPerson_Ihr("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine();
        }
    }
}
