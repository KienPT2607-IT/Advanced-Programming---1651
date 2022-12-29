namespace CarCustomizingSystem
{
    public class Nitro
    {
        private string name;
        private int capacity;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Nitro(string name, int capacity, double price)
        {
            Name = name;
            Capacity = capacity;
            Price = price;
        }

        public string ShowSpecification()
        {
            return $"Nitro: Name-> {name}, Capacity-> {capacity}, Price-> {price} $";
        }
    }
}