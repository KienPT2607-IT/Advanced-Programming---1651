using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        // # -> protected | + -> public
        // Attributes
        // # name: string
        // # age: int
        // # count: int (for auto-increment)
        // # id: int

        protected string name;
        protected int age;
        protected static int count;
        protected int id;

        // Properties:
        // + Name: get/set
        // + Age: get/set
        // + ID: get/set 
        //      -> return "GCH + id"
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID
        {
            get { return "GCH" + id; }
        }

        // default constructor
        public Student()
        {
            Name = "XXX XXX XXX";
            Age = 18;
            id = ++count;
        }

        // parameter constructor
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            id = ++count;
        }

        // ShowInfor()
        public void ShowInfor()
        {
            System.Console.WriteLine($"\tID: {ID}");
            System.Console.WriteLine($"\tName: {Name}");
            System.Console.WriteLine($"\tAge: {Age}");
        }
    }
}