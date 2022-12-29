namespace CarCustomizingSystem
{
    public class Engine
    {
        private string name;
        private int power;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Engine(string name, int power, double price)
        {
            Name = name;
            Power = power;
            Price = price;
        }

        public string ShowSpecification()
        {
            return $"Engine: Name-> {name}, Capacity-> {power }, Price-> {price} $";
        }
    }
}