using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSellingOOP
{
    public class Staff
    {
        private const int PRICE = 4;
        private const double COUPON = 0.1;
        private string[] movies = { "Black Adam", "Black Panther 2", "Detective Conan" };
        public void PrintMovies()
        {
            Console.WriteLine("Choose the movie: ");
            for (var i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + movies[i]);
            }
        }

        public void PrintTicket(Ticket ticket)
        {
            // print ticket attributes (movie, seats, number)
            for (var i = 0; i < ticket.NSeats; i++)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("Seat: " + (i + 1));
                Console.WriteLine("Movie name: " + ticket.Movie);
                Console.WriteLine("Seat title: " + ticket.Seats[i]);
            }
        }
        public void PrintInvoice(Customer customer)
        {
            // calculate total payment based customer's ticket & vip
            double total = customer.MyTicket.NSeats * PRICE;
            if (customer.VIP == true)
                total -= total * COUPON;
            Console.WriteLine("-----------");
            Console.WriteLine("Total: " + total);
            Console.WriteLine();
        }

        public void SellTickets()
        {
            bool selling = true;
            while (selling)
            {
                PrintMovies();

                Customer customer = new Customer();
                int choice = customer.GetMovieChoice(movies.Length);
                int nTickets = customer.GetNumberOfTickets();
                string[] seats = customer.GetSeats(nTickets);
                string movie = movies[choice];

                Ticket ticket = new Ticket(movie, seats, nTickets);

                PrintTicket(ticket);

                customer.MyTicket = ticket;
                customer.SetVIP();

                PrintInvoice(customer);

                selling = isContinue();
            }
        }

        private bool isContinue()
        {
            Console.Write("Continue (y/n): ");
            string isContinue = Console.ReadLine();
            return isContinue == "y";
        }
    }
}