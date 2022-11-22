using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Product
    {
        protected string name;
        public string Name { get; set; }

        protected double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product()
        {
            Name = "I phone 11";
            Price = 370.5;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void ShowInfor()
        {
            System.Console.WriteLine($"name: {name}, price: {price}");
        }
    }
}