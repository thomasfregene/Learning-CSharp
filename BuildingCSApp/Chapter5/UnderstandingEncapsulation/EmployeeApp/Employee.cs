using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.EmployeeApp
{
    public class Employee
    {
        //field data
        private string EmpName;
        private int EmpId;
        private float CurrPay;

        //Encapsulation using traditional accessor and mutator
        //Accesor(get method)
        public string GetName()
        {
            return EmpName;
        }
        //mutator(set method)
        public void SetName(string name)
        {
            //do a check on incoming value before making assignment
            if (name.Length > 15)
            {
                Console.WriteLine("Name length exceeds 15 character");
            }
            EmpName = name;
        }

        //encapsulation using .Net properties
       public string Name
        {
            get { return EmpName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Name length exceeds 15 character");
                else
                    EmpName = value;

            }
        }

        public int Id
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public float Pay
        {
            get { return CurrPay; }
            set { CurrPay = value; }
        }

        //constructors
        public Employee() { }

        public Employee(string name, int id, float pay)
        {
            EmpName = name;
            EmpId = id;
            CurrPay = pay;
        }

        //methods
        public void GiveBonus(float amount)
        {
            CurrPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", EmpName);
            Console.WriteLine("Id: {0}", EmpId);
            Console.WriteLine("Pay: {0}", CurrPay);
        }

        public static void TestEmployeeApp()
        {
            Console.WriteLine("***** Fun with encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            //use the get/set method to interact with the object name
            emp.SetName("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());
        }
    }
}
