using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP1
{
    public class Teacher
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    name = "Donal Trump";
                }
                name = value;
            }
        }

        private string subject;
        public string Subject
        {
            get { return subject; }
            set
            {
                subject = value;
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age < 22)
                {
                    Console.WriteLine("Invalid age, default value used");
                }
                else
                {
                    age = value;
                }
            }
        }

        public Teacher()
        {
        
        }
    }
}