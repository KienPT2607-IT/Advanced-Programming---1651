using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class TopUpStudent : Student
    {
        // Attributes
        // - grade: int [0;100]
        // - ojt: string (passed or failed)

        private int grade;
        private string ojt;
        // Property
        // + Grade: int
        // + OJT: string
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 0 || value > 100)
                    grade = 0;
                else
                    grade = value;
            }
        }

        public string OJT
        {
            get { return ojt; }
            set
            {
                if (value != "fail" && value != "pass")
                    ojt = "fail";
                else
                    ojt = value;
            }
        }
        // default constructor
        public TopUpStudent()
        {
            Grade = 0;
            OJT = "fail";
        }

        // parameter constructor
        public TopUpStudent(string name, int age) : base(name, age)
        {
            Grade = 0;
            OJT = "fail";
        }

        // ShowInfor()
        public void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine($"\tGrade: {grade}");
            System.Console.WriteLine($"\tOJT: {ojt}\n");
        }
    }
}