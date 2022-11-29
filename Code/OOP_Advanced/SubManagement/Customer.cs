using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubManagement
{
    public abstract class Customer
    {
        protected static int count = 0;
        protected int id;
        public int ID
        {
            get { return id; }
        }
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Customer()
        {
            Name = "Default name";
            Email = "Default email";
            id = ++count;
        }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            id = ++count;
        }

        public virtual void ShowInfor()
        {
            System.Console.WriteLine($"Customer ID: {id}");
            System.Console.WriteLine($"Name: {name}");
            System.Console.WriteLine($"Email: {email}");
        }

        public abstract double GetPayment();
    }
}