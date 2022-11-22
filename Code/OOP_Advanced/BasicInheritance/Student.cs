using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class Student : Person
    {
        public Student()
        {
            System.Console.WriteLine("Student non-parameter constructor");
        }

        public Student(string name, int age) : base(name, age)
        {
            System.Console.WriteLine("Student parameter constructor");
        }
    }
}