using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSP
{
    public class Bot : Player
    {
        public Bot() : base("bot")
        {
        }

        public override void GenerateNumber()
        {
            number = new Random().Next(1, 6);
        }

        public override int GuessNumber()
        {
            int numb = new Random().Next(1, 6);
            System.Console.WriteLine($"Bot guess: {numb}");
            return numb;
        }


    }
}