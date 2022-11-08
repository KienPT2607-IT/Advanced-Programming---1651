using System;

namespace Rock
{
    class Program
    {
        const int REWARD = 5;
        static void Main(string[] args)
        {
            bool playing = true;
            int balance = EnterBalance();
            while (playing)
            {
                string computerChoice = GetComputerChoice();
                Console.WriteLine("Computer choice: " + computerChoice);

                // User chooses rock, paper, or scissors from the console
                string userChoice = GetUserChoice();

                // Compare two choices and determine the winner
                string result = CompareResult(userChoice, computerChoice);
                balance = ModifyBalance(balance, result);

                DisplayResultAndBalance(result, balance);
                playing = IsEnoughToPlay(balance) && IsContinue();
            }
            DisplayEndingMessage(balance);
        }

        static void DisplayEndingMessage(int balance)
        {
            Console.WriteLine("Your final balance is: " + balance);
            Console.WriteLine("Thanks for playing");
        }

        static void DisplayResultAndBalance(string result, int balance)
        {
            Console.WriteLine("Game result:" + result);
            Console.WriteLine("Your balance now: " + balance);
        }

        static bool IsContinue()
        {
            Console.WriteLine("Do you wanna play again? (y/n)");
            string playAgain = Console.ReadLine();
            return playAgain == "y";
        }

        static bool IsEnoughToPlay(int balance)
        {
            return balance >= 5;
        }

        static int EnterBalance()
        {
            int balance = Convert.ToInt32(Console.ReadLine());
            return balance;
        }

        static int ModifyBalance(int balance, string result)
        {
            if (result == "Win") balance += REWARD;
            else if (result == "Lose") balance -= REWARD;
            return balance;
        }

        static string GetUserChoice()
        {
            string userChoice = "";
            bool validChoice = false;
            while (!validChoice)
            {
                Console.WriteLine("Choose Rock, Paper, or Scissors: ");
                userChoice = Console.ReadLine();
                validChoice = userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors";
                if (!validChoice)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            return userChoice;
        }

        static string CompareResult(string userChoice, string computerChoice)
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
        static string GetComputerChoice()
        {
            // Computer chooses a random number between 1 and 3
            Random random = new Random();
            //int computerChoice = random.Next(1, 4);
            string[] choices = { "Rock", "Paper", "Scissors" };
            // convert to string (rock, paper, scissors)
            string computerChoice = choices[random.Next(1, 4) - 1];
            return computerChoice;
        }
    }
}
