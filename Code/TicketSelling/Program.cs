using System;

namespace TicketSelling
{
    class Program
    {
        static string[] movies = { "Black Panther 2", "Black Adam", "Harry Potter" };
        const int price = 5;
        const double COUPON = 0.1;
        static void Main(string[] args)
        {
            bool isContinue = true;
            while (isContinue)
            {
                // Display a menu including 3 movies
                PrintMenu(movies);

                // Let user choose a movie
                string movie = GetMovie();

                // Let user choose number of tickets
                int nTickets = GetNumberOfTickets();

                // Let user choose seats
                string[] seats = GetSeats(nTickets);

                // Ask if his/her is a VIP member
                bool VIP = IsVIP();

                // Print out tickets and invoice
                PrintTickets(movie, seats);
                PrintInvoice(nTickets, VIP);

                // Return to the menu
                isContinue = IsContinue();
            }

        }

        static bool IsContinue()
        {
            Console.Write("Continue? (y/n): ");
            string message = Console.ReadLine();
            return message == "y";
        }

        static void PrintMenu(string[] movies)
        {
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + movies[i]);
            }
        }

        static string GetMovie()
        {
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return movies[choice - 1];
        }

        static int GetNumberOfTickets()
        {
            Console.Write("Number of tickets: ");
            int nTickets = int.Parse(Console.ReadLine());
            return nTickets;
        }

        static string[] GetSeats(int nTickets)
        {
            // Use iteration to repeat nTickets time, asking a seat then add to a string
            // -> return that string
            string[] seats = new string[nTickets];
            for (var i = 0; i < seats.Length; i++)
            {
                Console.Write("Choose your seat: ");
                seats[i] = Console.ReadLine();
            }
            Console.WriteLine("---------------\n");
            return seats;
        }

        static bool IsVIP()
        {
            Console.Write("Are u a VIP member? (y/n): ");
            string answer = Console.ReadLine();
            Console.WriteLine("---------------\n");
            return answer == "y";
        }

        static void PrintTickets(string movieName, string[] seats)
        {
            for (var i = 0; i < seats.Length; i++)
            {
                Console.WriteLine("Ticket: " + (i + 1));
                Console.WriteLine("Movie: " + movieName);
                Console.WriteLine("Seats: " + seats[i]);
                Console.WriteLine("---------------\n");
            }

        }

        static void PrintInvoice(int nTickets, bool VIP)
        {
            double payment = nTickets * price;
            if (VIP) payment -= payment * COUPON;
            Console.WriteLine("Payment: " + payment + "$");
        }
    }
}
