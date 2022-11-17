using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class InventoryProgram
    {
        private Inventory myIVT;

        public InventoryProgram()
        {
            myIVT = new Inventory();
        }

        public void Run()
        {
            // Print menu consists of 3 options
            // 1. Import a product
            // 2. Export a product
            // 3. Show all products
            bool isContinue = true;
            while (isContinue)
            {
                DisplayMenu();
                int choice = GetChoice();
                Process(choice);
                isContinue = IsContinue();
            }

        }

        private void Process(int choice)
        {
            switch (choice)
            {
                case 1:
                    myIVT.Import();
                    break;
                case 2:
                    myIVT.Export();
                    break;
                case 3:
                    myIVT.ShowProducts();
                    break;
                default:
                    System.Console.WriteLine("Not a valid choice\n");
                    break;
            }
        }

        private int GetChoice()
        {
            System.Console.Write("\tChoice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        private bool IsContinue()
        {
            System.Console.Write("Continue (y/n): ");
            string choice = Console.ReadLine();
            return choice == "y";
        }

        private void DisplayMenu()
        {
            System.Console.WriteLine("1. Import");
            System.Console.WriteLine("2. Export");
            System.Console.WriteLine("3. Show");
        }
    }
}