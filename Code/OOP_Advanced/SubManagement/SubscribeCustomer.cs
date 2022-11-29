using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubManagement
{
    public class SubscribeCustomer : Customer
    {
        private const int MONTHLY = 250000;
        private const double SALE = 0.2;
        private int subType;
        public int SubType
        {
            get { return subType; }
            set { subType = value; }
        }
        public SubscribeCustomer()
        {
            subType = 0; //monthly subscribe by default
        }

        public SubscribeCustomer(string name, string email, int subType) : base(name, email)
        {
            this.subType = subType;
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine($"SubType: {subType}");
        }

        public override double GetPayment()
        {
            if (subType == 0)
                return MONTHLY;
            else
                return MONTHLY * (1 - SALE);
        }
    }
}