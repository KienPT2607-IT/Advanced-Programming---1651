using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class SchoolProgram
    {
        // attribute: school
        private School mySchool;

        // default constructor
        public SchoolProgram()
        {
            mySchool = new School();
        }

        // Execute
        public void Execute()
        {
            bool isContinue = true;
            while (isContinue)
            {
                PrintMenu();
                int choice = GetChoice();
                Process(choice);
                isContinue = IsContinue();
            }
        }

        private bool IsContinue()
        {
            System.Console.Write("Continue (y/n): ");
            string choice = Console.ReadLine();
            return choice == "y";
        }

        // PrintMenu
        private void PrintMenu()
        {
            System.Console.WriteLine("1. Enroll a new student");
            System.Console.WriteLine("2. Drop a student out");
            System.Console.WriteLine("3. Show all students");
        }

        // GetChoice
        private int GetChoice()
        {
            System.Console.Write("\tChoosing: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        // Process
        private void Process(int choice)
        {
            switch (choice)
            {
                case 1:
                    mySchool.Enroll();
                    break;
                case 2:
                    mySchool.DropOupt();
                    break;
                case 3:
                    mySchool.ShowStudents();
                    break;
                default:
                    System.Console.WriteLine("Not a valid choice\n");
                    break;
            }
        }
    }
}