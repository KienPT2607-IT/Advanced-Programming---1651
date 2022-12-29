namespace CarCustomizingSystem
{
    public class Model
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Model(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string ShowSpecification()
        {
            return $"Model: Name-> {name}, Price-> {price} $";
        }
    }
}

