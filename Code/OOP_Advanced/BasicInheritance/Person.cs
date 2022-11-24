using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class Person
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person()
        {
            Name = "Ngoc Anh";
            Age = 20;
            System.Console.WriteLine("Person non-parameter constructor");
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            System.Console.WriteLine("Person parameter constructor");
        }

        public void Show()
        {
            System.Console.WriteLine($"{Name}, {Age}\n");
        }
    }
}