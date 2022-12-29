using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class Class
    {
        private List<Student> students;
        private ISortable sorter;
        public Class(ISortable sorter)
        {
            students = new List<Student>();
            this.sorter = sorter;
        }

        public void ChangeSorter(ISortable sorter)
        {
            this.sorter = sorter;
        }

        public void Show()
        {
            sorter.Sort(students);
            foreach (Student s in students)
            {
                System.Console.WriteLine(s.ToString());
            }
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }
    }
}