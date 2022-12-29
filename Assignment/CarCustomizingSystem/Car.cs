namespace CarCustomizingSystem
{
    public class Car
    {
        private string owner;
        private string modelName;
        private string engineName;
        private double price;

        protected string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        protected string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }
        protected string EngineName
        {
            get { return engineName; }
            set { engineName = value; }
        }
        protected double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car(string owner, string modelName, string engineName, double price)
        {
            Owner = owner;
            ModelName = modelName;
            EngineName = engineName;
            Price = price;
        }

        public virtual void ShowSpecification()
        {
            System.Console.WriteLine($"Owner: {owner}");
            System.Console.WriteLine($"Model-Name: {modelName}");
            System.Console.WriteLine($"Engine: {engineName}");
        }
    }
}

