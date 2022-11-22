using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class SaleProduct : Product
    {
        private double sale;
        public double Sale
        {
            get { return sale; }
            set
            {
                if (value < 0 || value > 1) sale = 0.5;
                else sale = value;
            }
        }

        public SaleProduct()
        {
            sale = 0.5;
        }

        public SaleProduct(string name, double price, double sale) : base(name, price)
        {
            Sale = sale;
        }

        public void ShowInfor()
        {
            double new_price = sale * price;
            System.Console.WriteLine($"name: {name}, price on sale: {new_price}");
        }
    }
}