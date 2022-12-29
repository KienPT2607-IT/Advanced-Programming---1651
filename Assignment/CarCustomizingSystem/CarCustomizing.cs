namespace CarCustomizingSystem
{
    public abstract class CarCustomizing
    {
        protected const double VAT = 0.1;
        protected const double WAGE = 0.25;
        public Car Build()
        {
            System.Console.WriteLine("--Customizing your dream car--");
            int model = ChooseModel();
            int engine = ChooseEngine();
            int specialModule = ChooseSpecialModule();
            string ownerName = GetOwnerName();
            Car car = BuildCar(ownerName, model, engine, specialModule);
            return car;
        }

        protected abstract Car BuildCar(string ownerName, int model, int engine, int specialModule);
        protected abstract int ChooseModel();
        protected abstract int ChooseEngine();
        protected abstract int ChooseSpecialModule();
        protected int GetChoice()
        {
            int choice = -1;
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("   --> Choosing: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    validChoice = true;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("*Not a valid choice!");
                }
            }
            return choice;
        }
        protected string GetOwnerName()
        {
            // Need to add try-catch block to valid input
            Console.Write("   Name of the Owner: ");
            string ownerName = Console.ReadLine();
            return ownerName;
        }
    }
}

