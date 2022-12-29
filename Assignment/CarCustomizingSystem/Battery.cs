namespace CarCustomizingSystem
{
    public class Battery
    {
        private int capacity;
        private double price;

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

        public Battery(int capacity, double price)
        {
            Capacity = capacity;
            Price = price;
        }

        public string ShowSpecification()
        {
            return $"Battery: Capacity-> {capacity}, Price-> {price} $";
        }
    }
}