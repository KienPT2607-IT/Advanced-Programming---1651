using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement
{
    public class SaleEmployee : Employee
    {
        private int sales;
        public int Sales
        {
            get { return sales; }
            set { sales = value; }
        }

        public SaleEmployee(string name, int age, double salary, int sales) : base(name, age, salary)
        {
            Sales = sales;
        }

        public override string ToString()
        {
            return $"Sale name: {name}, Age: {age}, Salary: {salary}, Sales: {sales}";
        }
    }
}