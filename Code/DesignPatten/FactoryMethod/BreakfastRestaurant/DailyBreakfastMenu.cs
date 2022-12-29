using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastRestaurant
{
    public abstract class DailyBreakfastMenu
    {
        public void ShowMenu()
        {
            System.Console.WriteLine("\n----------------\n");
            System.Console.WriteLine("Welcome to the restaurant");
            Breakfast bf = CreateBreakfast();
            bf.Show();
            string answer = Console.ReadLine();
            Console.WriteLine("Great choice! Please wait a moment");
        }

        protected abstract Breakfast CreateBreakfast();
    }
}