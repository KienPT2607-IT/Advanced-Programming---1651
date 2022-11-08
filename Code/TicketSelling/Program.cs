using System;

namespace TicketSelling
{
    class Program
    {
        static string[] movies = { "Black Panter 2", "Black Adam", "Harry Potter" };
        const int price = 5;
        const double COUPON = 0.1;
        static void Main(string[] args)
        {
            // Display a menu including 3 movies
            PrintMenu(movies);

            // Let user choose a movie
            string movie = GetMovie();

            // Let user choose number of tickets
            int nTickets = GetNumberOfTickets();

            // Let user choose seats
            string seats = GetSeats(nTickets);

            // Ask if his/her is a VIP member
            bool VIP = IsVIP();

            // Print out tickets and invoice
            PrintTickets(movie, nTickets, seats);
            PrintInvoice(nTickets, VIP);
            // Quay lại menu
        }

        static void PrintMenu(string[] movies)
        {
            for (int i = 0; i < movies.length; i++)
            {
                Console.WriteLine((i + 1) + ": " + movies[i]);
            }
        }

        static string GetMovie()
        {
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice - 1;
        }

        static int GetNumberOfTickets()
        {
            Console.Write("Number of tickets: ");
            int nTickets = int.Parse(Console.ReadLine());
            return nTickets;
        }

        static string GetSeats(int nTickets)
        {
            // Use iteration to repeat nTickets time, asking a seat then add to a string
            // -> return that string
            string seats = "";
            for (var i = 0; i < nTickets; i++)
            {
                Console.Write("Choose your seat: ");
                string seat = Console.ReadLine();
                seats += seat + " ";
            }
            return seats;
        }

        static bool IsVIP()
        {
            Console.Write("Are u a VIP member? (y/n): ");
            string answer = Console.ReadLine();
            return answer == "y";
        }

        static void PrintTickets(string movieName, int nTickets, string seat)
        {
            Console.WriteLine("Movie: " + movieName);
            Console.WriteLine("Number of tickets: " + nTickets);
            Console.WriteLine("Seats: " + seat);
        }

        static void PrintInvoice(int nTickets, bool VIP)
        {
            double payment = nTickets * price;
            if (VIP) payment -= payment * COUPON;
            Console.WriteLine("Payment: " + payment);
        }
    }
}
