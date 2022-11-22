using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class School
    {
        // attribute: List<Student> students
        private List<Student> students;

        // default constructor
        public School()
        {
            students = new List<Student>();
        }

        // Enroll(): enroll student
        public void Enroll()
        {
            System.Console.Write("Student name: ");
            string name = Console.ReadLine();

            System.Console.Write("\tAge: ");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("\tGrade: ");
            double grade = double.Parse(Console.ReadLine());

            students.Add(new Student(name, age, grade));
        }

        // DropOupt(): drop out student

        public void DropOupt()
        {
            System.Console.Write("Enter product ID: ");
            int ID = int.Parse(Console.ReadLine());

            bool isIDvalid = IsIDvalid(ID);
            if (!isIDvalid)
                System.Console.WriteLine("Invalid ID");

            Student std = FindByID(ID);
            if (std == null) System.Console.WriteLine($"Student id {ID} not found");
            else
            {
                students.Remove(std);
                System.Console.WriteLine($"Student {ID} dropped out");
            }
        }

        private bool IsIDvalid(int ID)
        {
            if (ID < 0)
                return false;
            else
                return true;
        }

        private Student FindByID(int id)
        {
            foreach (var student in students)
            {
                if (student.ID == id) return student;
            }
            return null;
        }

        // ShowStudents(): show all students    
        public void ShowStudents()
        {
            foreach (var std in students)
            {
                std.ShowInfor();
            }
        }
    }
}