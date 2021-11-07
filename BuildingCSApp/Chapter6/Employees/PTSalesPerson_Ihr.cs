using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCSApp.Chapter6.Employees
{
    public sealed class PTSalesPerson_Ihr : SalesPerson_Ihr
    {
        public PTSalesPerson_Ihr(string fullName, int age, int empId, float currPay, 
            string ssn, int numbOfSales)
            : base(fullName, age, empId, currPay, ssn, numbOfSales)
        {

        }
    }
}
