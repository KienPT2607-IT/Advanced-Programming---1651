using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement
{
    public class Candidate
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public Candidate(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, GPA: {GPA}";
        }
    }
}