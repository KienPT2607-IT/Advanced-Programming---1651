using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelMaketing
{
    public class NormalMember : Member
    {
        public NormalMember(string name, int products) : base(name, products)
        {
        }

        public override double GetSalary()
        {
            return PRICE * Products * (1 - COMMISSION);
        }
    }
}