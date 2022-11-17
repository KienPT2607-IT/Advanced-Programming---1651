using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Inventory
    {
        private List<Product> products;

        public Inventory()
        { products = new List<Product>(); }

        public void Import()
        {
            System.Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter product price: ");
            int price = int.Parse(Console.ReadLine());

            Product p = new Product(name, price);
            products.Add(p);
        }

        public void Export()
        {
            System.Console.Write("Enter product ID: ");
            int ID = int.Parse(Console.ReadLine());
            if (ID < 0)
            {
                System.Console.WriteLine("Invalid ID");
                return;
            }

            Product p = FindByID(ID);

            if (p == null) System.Console.WriteLine($"Product id {ID} not found");
            else
            {
                products.Remove(p);
                System.Console.WriteLine($"Product id {ID} deleted");
            }
        }

        public Product FindByID(int ID)
        {
            foreach (var item in products)
            {
                if (item.ID == ID) return item;
            }
            return null;
        }

        public void ShowProducts()
        {
            System.Console.WriteLine("All products kept: ");
            foreach (var item in products)
            {
                item.ShowInfor();
            }
        }
    }
}