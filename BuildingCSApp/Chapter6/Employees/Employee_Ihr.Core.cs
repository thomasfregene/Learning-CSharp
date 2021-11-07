using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.Employees
{
    //public abstract partial class Employee_Ihr
    public partial class Employee_Ihr
    {
        //field data
        private string EmpName;
        private int EmpId;
        private float CurrPay;
        private int EmpAge;
        private string EmpSSN;
        // Contain a BenefitPackage object.
        //protected BenefitPackage empBenefits = new BenefitPackage();


        
        //constructors
        public Employee_Ihr() { }

        //new ctor with ctor chaining
        public Employee_Ihr(string name, int id, float pay)
            : this(name, 0, id, pay, "") { }

        public Employee_Ihr(string name, int age, int id, float pay)
        {
            EmpName = name;
            EmpId = id;
            CurrPay = pay;
            Age = age;
            //EmpSSN = ssn;
        }

        public Employee_Ihr(string name, int age, int id, float pay, string ssn)
            : this(name, age, id, pay)
        {
            EmpSSN = ssn;
        }

    }
}
