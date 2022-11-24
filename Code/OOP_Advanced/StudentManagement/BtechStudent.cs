using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class BtechStudent : Student
    {
        // Class attributes
        private static string[] GRADES = { "fail", "pass", "merit", "distinction" };
        // Attributes
        // - grade :string ("Fail", "Pass", "Merit", "Distinction")
        private string grade;

        // Property
        // - Grade: string (validate value is one of 4 grades above)
        public string Grade
        {
            get { return grade; }
            set
            {
                if (value != GRADES[0] && value != GRADES[1] &&
                    value != GRADES[2] && value != GRADES[3])
                {
                    grade = GRADES[0];
                }
                else
                {
                    grade = value;
                }
            }
        }

        // default constructor
        public BtechStudent()
        {
            Grade = "fail";
        }

        // parameter constructor
        public BtechStudent(string name, int age) : base(name, age)
        {
            Grade = "fail";
        }

        // ShowInfor()
        public void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine($"\tGrade: {grade}\n");
        }
    }
}