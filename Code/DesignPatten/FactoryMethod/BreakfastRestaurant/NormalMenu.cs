using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastRestaurant
{
    public class NormalMenu : DailyBreakfastMenu
    {
        protected override Breakfast CreateBreakfast()
        {
            return new NormalBreakfast();
        }
    }
}