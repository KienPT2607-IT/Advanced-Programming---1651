using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement
{
    public class SaleHRDeparment : HRDepartment
    {
        protected override List<Candidate> CVRound(List<Candidate> candidates)
        {
            List<Candidate> passCV = new List<Candidate>();
            foreach (Candidate c in candidates)
            {
                if (c.Age >= 18 && c.Age <= 50 && c.GPA >= 4.0)
                {
                    passCV.Add(c);
                    System.Console.WriteLine($"Candidate {c.Name} pass CV round!");
                }
            }
            return passCV;
        }

        protected override List<Candidate> TestRound(List<Candidate> passedCV)
        {
            // No need to take the test round
            return passedCV;
        }

        protected override List<Candidate> Interviewround(List<Candidate> pasesdTest)
        {
            List<Candidate> passInterview = new List<Candidate>();
            foreach (Candidate c in pasesdTest)
            {
                System.Console.WriteLine("Sell me this pen!");
                System.Console.Write("Candidate answer: ");
                Console.ReadLine();
                System.Console.Write("Did he or she answer it correctly? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    System.Console.WriteLine("Candidate passed interview round");
                    passInterview.Add(c);
                }
            }
            return passInterview;
        }

        protected override Employee Offer(Candidate candidate)
        {
            System.Console.Write($"How much salary for {candidate.Name}? ");
            double salary = double.Parse(Console.ReadLine());
            System.Console.Write($"Sales {candidate.Name} can achieve: ");
            int sales = int.Parse(Console.ReadLine());

            return new SaleEmployee(candidate.Name, candidate.Age, salary, sales);
        }
    }
}