using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.EmployeeApp
{
    public partial class Employee
    {
       
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

        public int GetAge()
        {
            return EmpAge;
        }
        public void SetAge(int age)
        {
            Age = age;
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

        public int Age
        {
            get { return EmpAge; }
            set { EmpAge = value; }
        }

        //read-only property
        public string SocialSecurityNumber
        {
            get { return EmpSSN; }
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
            Employee emp = new Employee("Marvin", 30, 456, 30000, "");
            emp.GiveBonus(1000);
            emp.DisplayStats();

            //use the get/set method to interact with the object name
            emp.SetName("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());
        }

        public static void TestEmployeeAppWithPpty()
        {
            Console.WriteLine("***** Fun with encapsulation *****\n");
            Employee emp = new Employee("Marvin", 30, 456, 30000, "");
            emp.GiveBonus(1000);
            emp.DisplayStats();
            //Reset and then get the name property
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);

        }

        public static void IncreamentAgeOnBirthday()
        {
            //With Traditional accessor and mutator methods
            //age increament will be as follows
            Employee joe = new Employee();
            joe.SetAge(30);
            joe.SetAge(joe.GetAge() + 1);
            Console.WriteLine("Employee Age: {0}", joe.GetAge());

            //with encapsulated property 
            joe.Age = 40;
            joe.Age++;
            Console.WriteLine("Employee age: {0}", joe.Age);
            Console.WriteLine();
        }
    }
}
