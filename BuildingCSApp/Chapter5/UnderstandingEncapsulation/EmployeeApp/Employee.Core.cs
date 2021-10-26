using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter5.UnderstandingEncapsulation.EmployeeApp
{
    partial class Employee
    {
        //field data
        private string EmpName;
        private int EmpId;
        private float CurrPay;
        private int EmpAge;
        private string EmpSSN;
       
        //constructors
        public Employee() { }

        //new ctor with ctor chaining
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "") { }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            EmpName = name;
            EmpId = id;
            CurrPay = pay;
            Age = age;
            EmpSSN = ssn;
        }

    }
}
