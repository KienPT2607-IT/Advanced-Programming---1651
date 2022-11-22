using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
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