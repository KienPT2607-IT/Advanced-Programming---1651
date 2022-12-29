using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelMaketing
{
    public class Company
    {
        private List<Member> members = new List<Member>();

        public Company()
        {
            members = new List<Member>();
        }

        public void AddTopMember(ReferenceMember member)
        {
            members.Add(member);
        }

        public double CalculateIncome()
        {
            double income = 0;
            foreach (Member member in members)
            {
                income += (member.GetSalary() / (1 - Member.COMMISSION)) + Member.COMMISSION;
            }
            return income;
        }

        public void Show()
        {
            System.Console.WriteLine("All member of the company");
            foreach (Member member in members)
            {
                member.Show();
            }
        }
    }
}