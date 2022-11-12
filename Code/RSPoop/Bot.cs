using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSPoop
{
    public class Bot
    {
        public string GetChoice()
        {
            Random random = new Random();
            string[] choices = { "Rock", "Paper", "Scissors" };
            string computerChoice = choices[random.Next(1, 4) - 1];
            return computerChoice;
        }
    }
}