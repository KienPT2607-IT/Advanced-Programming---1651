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

            for (var i = 0; i < products.Count; i++)
            {
                if (products[i].ID == ID)
                {
                    products.Remove(products[i]);
                    break;
                }
            }
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