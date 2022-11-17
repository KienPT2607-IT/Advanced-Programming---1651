using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSellingOOP
{
    public class Customer
    {
        private const int minNTicket = 1;
        private const int maxTicket = 5;

        public bool VIP { get; set; }
        public Ticket MyTicket { get; set; }

        public Customer()
        {
            MyTicket = new Ticket();
        }
        public int GetMovieChoice(int maxChoice)
        {
            // ask user to enter a choice (1, 2, 3, ..)
            bool invalidChoice = true;
            int choice = 0;
            while (invalidChoice)
            {
                Console.Write("Which movie (1, 2, 3, ...): ");
                choice = int.Parse(Console.ReadLine());
                invalidChoice = (choice < 1) || (choice > maxChoice);
                if (invalidChoice)
                    Console.WriteLine("Invalid choice: Try again!\n");
            }
            // then return choice
            return choice - 1;
        }

        public int GetNumberOfTickets()
        {
            // ask user to enter number of tickets
            bool invalidNOfTickets = true;
            int nTickets = 0;
            while (invalidNOfTickets)
            {
                Console.Write("How many tickets: ");
                nTickets = int.Parse(Console.ReadLine());
                invalidNOfTickets = (nTickets < minNTicket) || (nTickets > maxTicket);
                if (invalidNOfTickets)
                    System.Console.WriteLine($"Only allows: {minNTicket} to {maxTicket}\n");
            }
            // return number
            return nTickets;
        }

        public string[] GetSeats(int nTickets)
        {
            // use for loop to ask user enter seats, concat seat to a string
            string[] seats = new string[nTickets];
            Console.WriteLine("Choose the seat: ");
            for (int i = 0; i < nTickets; i++)
            {
                Console.Write("\t- ");
                seats[i] = Console.ReadLine();
            }
            // return seats string
            return seats;
        }

        public void SetVIP()
        {
            // ask user if user wants to be VIP or not
            Console.Write("Are you a VIP? (y/n): ");
            // set VIP property
            string isVIP = Console.ReadLine();
            VIP = (isVIP == "y");
        }
    }

}