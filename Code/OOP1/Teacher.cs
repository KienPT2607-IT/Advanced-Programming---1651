using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP1
{
    public class Teacher
    {
        private string name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        private string subject
        {
            get { return subject; }
            set
            {
                subject = value;
            }
        }

        private int age
        {
            get { return age; }
            set
            {
                if (age < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}