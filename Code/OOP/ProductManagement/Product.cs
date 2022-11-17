using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; } // Short-cut or No attribute
        private int id;
        private static int count = 0;
        public int ID
        {
            get { return id; }
        }

        public Product()
        {
            Name = "No name";
            Price = 0;
            id = raiseProduct();
        }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            id = raiseProduct();
        }

        private int raiseProduct()
        {
            return ++count;
        }

        public void ShowInfor()
        {
            System.Console.WriteLine($"ID: {ID}, Name: {Name}, Price: {Price}");
        }
    }
}