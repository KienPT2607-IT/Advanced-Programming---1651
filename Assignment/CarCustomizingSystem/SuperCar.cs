namespace CarCustomizingSystem
{
    public class SuperCar : Car
    {
        private string nitroBooster;
        public string NitroBooster
        {
            get { return nitroBooster; }
            set { nitroBooster = value; }
        }

        public SuperCar(string owner, string modelName, string engineName, string nitroBooster, double price) :
            base(owner, modelName, engineName, price)
        {
            NitroBooster = nitroBooster;
        }

        public override void ShowSpecification()
        {
            base.ShowSpecification();
            System.Console.WriteLine($"Nitro-Booster: {nitroBooster}");
            System.Console.WriteLine($"Price: {Price} $");
        }
    }
}
