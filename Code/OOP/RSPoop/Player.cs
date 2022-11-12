using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSPoop
{
    public class Player
    {
        private int balance;
        public int Balance
        {
            get { return balance; }
            // set { balance = value; } 
        }

        public Player()
        {
            balance = 0;
        }

        public string GetChoice()
        {
            string userChoice = "";
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("Choose Rock, Paper or Scissors: ");
                userChoice = Console.ReadLine();
                validChoice = userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors";
                if (!validChoice)
                {
                    Console.WriteLine("Invalid choice. Please try again!");
                }
            }
            return userChoice;
        }

        public bool IsPlayAgain()
        {
            Console.Write("Do you wanna play again? (y/n): ");
            string playAgain = Console.ReadLine();
            return playAgain == "y";
        }

        public void Deposit(int amount)
        {
            if (amount == 0)
                Console.WriteLine("Invalid amount. Transaction in canceled");
            else
                balance += amount;
        }

        public void UpdateBalance(int amount)
        {
            balance += amount;
        }
    }
}