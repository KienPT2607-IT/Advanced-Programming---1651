using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class School
    {
        private List<BtechStudent> btechStudents;
        private List<TopUpStudent> topUpStudents;

        public School()
        {
            btechStudents = new List<BtechStudent>();
            topUpStudents = new List<TopUpStudent>();
        }

        public void PrintMenu()
        {
            // 1. Enroll a new student
            System.Console.WriteLine("1. Enroll a new student");
            // 2. Move to TopUp
            System.Console.WriteLine("2. Move to TopUp");
            // 3. Show Btech students
            System.Console.WriteLine("3. Show Btech students");
            // 4. Show TopUp students
            System.Console.WriteLine("4. Show TopUp students");
            // 5. Grade BTech students
            System.Console.WriteLine("5. Grade BTech students");
            // 6. Grade TopUp students
            System.Console.WriteLine("6. Grade TopUp students");
        }

        public int GetChoice()
        {
            Console.Write("\tChoose one:");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public void Process(int choice)
        {
            switch (choice)
            {
                case 1:
                    Enroll();
                    break;
                case 2:
                    MoveToTopUp();
                    break;
                case 3:
                    ShowBtech();
                    break;
                case 4:
                    ShowTopUp();
                    break;
                case 5:
                    GradeBtechStudents();
                    break;
                case 6:
                    GradeTopUpStudents();
                    break;
                default:
                    break;
            }
        }

        private void Enroll()
        {
            System.Console.Write("Student name: ");
            string name = Console.ReadLine();

            System.Console.Write("\tAge: ");
            int age = int.Parse(Console.ReadLine());

            btechStudents.Add(new BtechStudent(name, age));
        }

        private void MoveToTopUp()
        {
            // Enter id
            string id = GetID();

            // find in btechList
            foreach (BtechStudent each in btechStudents)
            {
                if (id == each.ID)
                {
                    // create a topup student based on the btech student
                    // add the topup student object to topUp list
                    topUpStudents.Add(new TopUpStudent(each.Name, each.Age));

                    // remove that btech student from list
                    btechStudents.Remove(each);
                    break;
                }
            }
            System.Console.WriteLine($"ID: {id} not found");
        }

        private string GetID()
        {
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            return id;
        }
        private void ShowBtech()
        {
            if (btechStudents.Count == 0)
            {
                System.Console.WriteLine("BTech list empty\n");
                return;
            }
            foreach (BtechStudent each in btechStudents)
            {
                each.ShowInfor();
            }
        }

        private void ShowTopUp()
        {
            if (topUpStudents.Count == 0)
            {
                System.Console.WriteLine("TopUp list empty\n");
                return;
            }
            foreach (TopUpStudent each in topUpStudents)
            {
                each.ShowInfor();
            }
        }

        private void GradeBtechStudents()
        {
            foreach (BtechStudent each in btechStudents)
            {
                System.Console.WriteLine($"\nGrade for student {each.Name}:");
                System.Console.WriteLine("\t<fail - pass - merit - distinction>");
                System.Console.Write("\tEnter grade: ");
                each.Grade = Console.ReadLine();
            }
        }

        private void GradeTopUpStudents()
        {
            foreach (TopUpStudent each in topUpStudents)
            {
                System.Console.WriteLine($"\nGrade for student {each.Name}:");
                System.Console.Write("\tEnter grade [0;100]: ");
                each.Grade = int.Parse(Console.ReadLine());
            }
        }
    }
}