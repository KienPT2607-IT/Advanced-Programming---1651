using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSPoop
{
    public class Game
    {
        private const int REWARD = 10;
        private Player player;
        private Bot bot;
        public Game()
        {
            player = new Player();
            bot = new Bot();
        }

        public string CompareChoices(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "Tie";
            }
            else if (userChoice == "Rock" && computerChoice == "Scissors" ||
                userChoice == "Paper" && computerChoice == "Rock" ||
                userChoice == "Scissors" && computerChoice == "Paper")
            {
                return "Win";
            }
            else
            {
                return "Lose";
            }
        }

        public void UpdatePlayerBalance(string result)
        {
            if (result == "Win") player.UpdateBalance(REWARD);
            else if (result == "Lose") player.UpdateBalance(-REWARD);
        }

        public void PrintGameStatus(string result)
        {
            Console.WriteLine("Game result: " + result);
            Console.WriteLine("\tYour current balance:" + player.Balance);
            Console.WriteLine("--------------------------\n");
        }

        public void PrintFinalStatus(string result)
        {
            Console.WriteLine("Your current balance:" + player.Balance);
            Console.WriteLine("--------------------------\n");
        }

        public void Play()
        {
            player.Deposit(1910);
            bool playing = true;
            while (playing)
            {
                string computerChoice = bot.GetChoice();
                string userChoice = player.GetChoice();

                string result = CompareChoices(userChoice, computerChoice);
                UpdatePlayerBalance(result);
                PrintGameStatus(result);

                playing = player.Balance >= REWARD && player.IsPlayAgain();
            }
        }

    }
}