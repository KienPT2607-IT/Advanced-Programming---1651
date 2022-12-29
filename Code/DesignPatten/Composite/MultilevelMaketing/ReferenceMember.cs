using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelMaketing
{
    public class ReferenceMember : Member
    {
        private List<Member> members;

        public ReferenceMember(string name, int products) : base(name, products)
        {
            members = new List<Member>();
        }

        public void Add(Member member)
        {
            members.Add(member);
        }

        public override double GetSalary()
        {
            double salary = Products * PRICE;
            foreach (Member member in members)
            {
                salary += (member.GetSalary() / (1 - COMMISSION)) * COMMISSION;
            }
            salary += 1 - COMMISSION;
            return salary;
        }

        public override void Show()
        {
            base.Show();
            System.Console.WriteLine("List of member");
            foreach (Member member in members)
            {
                member.Show();
            }
        }

        
    }
}