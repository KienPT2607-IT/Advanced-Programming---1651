using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Shop
    {
        private List<Product> products;
        private List<SaleProduct> saleProducts;
        public Shop()
        {
            products = new List<Product>();
            saleProducts = new List<SaleProduct>();
        }

        public void PrintMenu()
        {
            System.Console.WriteLine("1. Insert a new product");
            System.Console.WriteLine("2. Sell a product");
            System.Console.WriteLine("3. Quit");
        }

        public int GetChoice()
        {
            Console.Write("\tChoose one:");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public void AddNewProduct()
        {
            Console.Write("Insert a \'normal\' or \'sale\' product (n\\s): ");
            string answer = Console.ReadLine();

            Product product = InsertProduct();
            if (answer == "y")
            {
                products.Add(product);
            }
            else
            {
                Console.Write("\tSale (1->100): ");
                int sale = int.Parse(Console.ReadLine());
                saleProducts.Add(new SaleProduct(product.Name, product.Price, sale / 100.0));
            }
        }

        public void SellProduct()
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            foreach (SaleProduct item in saleProducts)
            {
                if (item.Name == name)
                {
                    item.ShowInfor();
                    System.Console.WriteLine($"Product: {item.Name}: sold");
                    return;
                }
            }
            foreach (Product item in products)
            {
                if (item.Name == name)
                {
                    item.ShowInfor();
                    System.Console.WriteLine($"Product: {item.Name}: sold");
                    return;
                }
            }
            System.Console.WriteLine($"Product {name} not found");
        }

        private Product InsertProduct()
        {
            Console.Write("\tName: ");
            string name = Console.ReadLine();
            Console.Write("\tPrice: ");
            double price = double.Parse(Console.ReadLine());
            return new Product(name, price);
        }
    }
}