using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement
{
    public abstract class HRDepartment
    {
        public List<Employee> Recruit(List<Candidate> candidates)
        {
            List<Employee> employees = new List<Employee>();
            List<Candidate> passedCV = CVRound(candidates);
            List<Candidate> passedTest = TestRound(passedCV);
            List<Candidate> passedInterview = Interviewround(passedTest);

            foreach (var candidate in passedInterview)
            {
                Employee employee = Offer(candidate);
                employees.Add(employee);
            }
            return employees;
        }

        protected abstract List<Candidate> CVRound(List<Candidate> candidates);
        protected abstract List<Candidate> TestRound(List<Candidate> passedCV);
        protected abstract List<Candidate> Interviewround(List<Candidate> pasesdTest);
        protected abstract Employee Offer(Candidate candidate);
    }
}