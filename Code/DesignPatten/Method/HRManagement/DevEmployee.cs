using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement
{
    public class DevEmployee : Employee
    {
        private string language;
        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public DevEmployee(string name, int age, double salary, string language) : base(name, age, salary)
        {
            Language = language;
        }

        public override string ToString()
        {
            return $"Dev name: {name}, Age: {age}, Salary: {salary}, Language: {language}";
        }
    }
}