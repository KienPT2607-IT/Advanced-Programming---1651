using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCustomizingSystem
{
    public class CarCustomizingProgram
    {
        protected const int EXIT = 0;
        public void Run()
        {
            bool running = true;
            while (running)
            {
                // Display menu
                DisplayMenu();
                // Get user choice
                int choice = GetChoice();
                if (choice == 0) break;
                // Build car based on the user's choice
                CarCustomizing carCustomizing = Process(choice);
                Car carCustomized = null;
                try
                {
                    carCustomized = carCustomizing.Build();
                    // Print the invoice
                    PrintInvoice(carCustomized);
                }
                catch (NullReferenceException)
                {
                    System.Console.WriteLine("*Not a valid choice, please choose again! ");
                }
            }
            System.Console.WriteLine("---------Goodbye---------");
        }

        private int GetChoice()
        {
            int choice = -1;
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("   --> Choosing: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    validChoice = true;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("*Not a valid choice!");
                }
            }
            return choice;
        }

        private void DisplayMenu()
        {
            System.Console.WriteLine("1: Super Car");
            System.Console.WriteLine("2: Electric Car");
            System.Console.WriteLine("0: Exit");
            System.Console.WriteLine("-------------------------");
        }

        private CarCustomizing Process(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new SuperCarCustomizing();
                case 2:
                    return new ElectricCarCustomizing();
                default:
                    return null;
            }
        }

        private void PrintInvoice(Car car)
        {
            System.Console.WriteLine();
            car.ShowSpecification();
            System.Console.WriteLine();
        }

    }
}