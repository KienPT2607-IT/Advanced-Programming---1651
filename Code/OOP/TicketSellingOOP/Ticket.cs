using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSellingOOP
{
    public class Ticket
    {
        private string movie;
        private string[] seats;
        private int nSeats;

        public string Movie
        {
            get { return movie; }
            set { movie = value; }
        }

        // Properties
        public string[] Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public int NSeats
        {
            get { return nSeats; }
            set { nSeats = value; }
        }

        // Default and Parameterized constructors
        public Ticket()
        {
            Movie = "";
            Seats = null;
            NSeats = 0;
        }

        public Ticket(string movie, string[] seats, int nSeats)
        {
            this.movie = movie;
            this.seats = seats;
            this.nSeats = nSeats;
        }
    }
}