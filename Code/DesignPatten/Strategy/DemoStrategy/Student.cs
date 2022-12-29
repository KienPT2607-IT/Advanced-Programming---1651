using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class Student
    {
        public string Name { get; set; }
        public double GPA { get; set; }
        public int Age { get; set; }
        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }

        public string ToString()
        {
            return $"Name: {Name}, Age: {Age}, GPA: {GPA}";
        }
    }
}