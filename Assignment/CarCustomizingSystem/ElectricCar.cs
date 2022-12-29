namespace CarCustomizingSystem
{
    public class ElectricCar : Car
    {
        private int batteryCapacity;
        public int BatteryCapacity
        {
            get { return batteryCapacity; }
            set { batteryCapacity = value; }
        }

        public ElectricCar(string owner, string modelName, string engineName, int batteryCapacity, double price) :
            base(owner, modelName, engineName, price)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override void ShowSpecification()
        {
            base.ShowSpecification();
            System.Console.WriteLine($"Battery capacity: {batteryCapacity}");
            System.Console.WriteLine($"Price: {Price} $");
        }
    }
}

