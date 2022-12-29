using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastRestaurant
{
    public class Restaurant
    {
        private DailyBreakfastMenu menu;

        public void Open()
        {
            // Get correct day of week
            DayOfWeek day = DateTime.Now.DayOfWeek;
            // Check if it is weekend or net
            if (day == DayOfWeek.Sunday || day == DayOfWeek.Saturday)
            {
                menu = new WeekendMenu();
            }
            else
            {
                menu = new NormalMenu();
            }
            System.Console.WriteLine($"Today is {day}");
            System.Console.WriteLine("Opening the restaurant");
        }

        public void WelcomeCustomer()
        {
            while (true)
            {
                System.Console.WriteLine("Welcome to the restaurant");
                menu.ShowMenu();
                System.Console.WriteLine("--Waiting for the new customer--");
                string c = Console.ReadLine();
                if (c == "q") break;
            }
        }
    }
}