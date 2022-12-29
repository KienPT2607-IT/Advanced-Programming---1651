using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastRestaurant
{
    public class NormalBreakfast : Breakfast
    {
        public override void Show()
        {
            System.Console.WriteLine("Normal daily breakfast");
            System.Console.WriteLine("Today we have");
            System.Console.WriteLine("1. Bread");
            System.Console.WriteLine("2. Eggs");
            System.Console.WriteLine("3. Coffee");
            System.Console.Write("What do you choose: ");
        }
    }
}