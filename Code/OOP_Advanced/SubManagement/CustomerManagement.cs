using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubManagement
{
    public class CustomerManagement : MenuProgram
    {
        private List<Customer> customers;

        public CustomerManagement()
        {
            customers = new List<Customer>();
        }

        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Add PPV customer");
            System.Console.WriteLine("2. Add Sub customer");
            System.Console.WriteLine("3. PrintBill");
            System.Console.WriteLine("0. Exit");
        }

        protected override void Process(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddPPVCustomer();
                    break;
                case 2:
                    AddSubCustomer();
                    break;
                case 3:
                    PrintBill();
                    break;
                case 0:
                    break;
                default:
                    System.Console.WriteLine("Invalid choice\n");
                    break;
            }

        }

        private void PrintBill()
        {
            foreach (Customer cus in customers)
            {
                cus.ShowInfor();
                System.Console.WriteLine($"Payment: {cus.GetPayment()}");
                System.Console.WriteLine("---------------------\n");
            }
        }

        private void AddSubCustomer()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Subscribe type (0: monthly, 1: yearly): ");
            int subType = int.Parse(Console.ReadLine());
            customers.Add(new SubscribeCustomer(name, email, subType));
        }

        private void AddPPVCustomer()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Number of movies: ");
            int movies = int.Parse(Console.ReadLine());
            customers.Add(new PPVCustomer(name, email, movies));
        }
    }
}