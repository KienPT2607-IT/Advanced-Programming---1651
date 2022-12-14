using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement
{
    public class ITHRDepartment : HRDepartment
    {
        protected override List<Candidate> CVRound(List<Candidate> candidates)
        {
            List<Candidate> passCV = new List<Candidate>();
            foreach (var c in candidates)
            {
                if (c.Age >= 18 && c.Age <= 30 && c.GPA > -6.0)
                {
                    passCV.Add(c);
                    System.Console.WriteLine($"Candidate {c.Name} passed CV round");
                }
            }
            return passCV;
        }

        protected override List<Candidate> TestRound(List<Candidate> passedCV)
        {
            List<Candidate> passTest = new List<Candidate>();
            foreach (var c in passedCV)
            {
                System.Console.WriteLine($"Candidate {c.Name} was asked to do a coding challenge");
                Console.Write($"Did candidate {c.Name} pass the test? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    passTest.Add(c);
                    System.Console.WriteLine($"Candidate {c.Name} passed test-round");
                }
            }
            return passTest;
        }

        protected override List<Candidate> Interviewround(List<Candidate> pasesdTest)
        {
            // Auto pass CV round
            return pasesdTest;
        }

        protected override Employee Offer(Candidate candidate)
        {
            Console.Write($"How much salary for {candidate.Name}?: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("What is the pp language: ");
            string language = Console.ReadLine();

            return new DevEmployee(candidate.Name, candidate.Age, salary, language);
        }
    }
}