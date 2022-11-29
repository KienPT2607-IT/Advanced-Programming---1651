using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubManagement
{
    public class PPVCustomer : Customer
    {
        private const int PRICE = 10;
        private int movies;
        public int Movies
        {
            get { return movies; }
            set { movies = value; }
        }

        public PPVCustomer()
        {
            movies = 0;
        }

        public PPVCustomer(string name, string email, int movies) : base(name, email)
        {
            this.movies = movies;
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine($"Movies: {movies}");
        }

        public override double GetPayment()
        {
            return movies * PRICE;
        }
    }
}