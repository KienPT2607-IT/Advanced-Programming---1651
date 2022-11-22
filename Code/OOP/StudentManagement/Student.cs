using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        private static int count = 0;
        /* 
        attributes:
            int: ID base count,
            
            string: name, 
            int age, 
            double grade x.xx
        */
        public int ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        // default constructor
        public Student()
        {
            ID = ++count;
            Name = "No Name";
            Age = 18;
            Grade = 0;
        }


        // parameter constructor
        public Student(string name, int age, double grade)
        {
            ID = ++count;
            Name = name;
            Age = age;
            Grade = grade;
        }

        // show info
        public void ShowInfor()
        {
            System.Console.WriteLine($"Student - {Name}");
            System.Console.WriteLine($"\tID: {ID}");
            System.Console.WriteLine($"\tAge: {Age}");
            System.Console.WriteLine($"\tGrade: {Grade}");
        }
    }
}