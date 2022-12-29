using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastRestaurant
{
    public class WeekendBreakfast : Breakfast
    {
        public override void Show()
        {
            System.Console.WriteLine("\n-----------------------\n");
            System.Console.WriteLine("Weekend Breakfast");
            System.Console.WriteLine("1. Pancakes");
            System.Console.WriteLine("2. Sausages");
            System.Console.WriteLine("3. Cake");
            System.Console.WriteLine("4. Coffee");
            System.Console.Write("What do you choose: ");
        }
    }
}