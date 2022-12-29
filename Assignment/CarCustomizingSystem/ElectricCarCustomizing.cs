namespace CarCustomizingSystem
{
    public class ElectricCarCustomizing : CarCustomizing
    {
        private static List<Model> models = new List<Model>()
        {
            new Model("Testla model X", 136700),
            new Model("Mercedes-Benz EQS", 250000),
            new Model("Porsche Taycan", 372000),
            new Model("Tesla Model 3", 123000),
            new Model("Hyundai Ioniq 5", 62000)
        };
        private static List<Engine> engines = new List<Engine>()
        {
            new Engine("Electric motor VSX", 250, 12000),
            new Engine("Electric motor AKA", 312, 21000),
            new Engine("Electric motor SSS", 183, 15600)
        };
        private static List<Battery> batteries = new List<Battery>()
        {
            new Battery(600, 25000),
            new Battery(300, 10000),
            new Battery(800, 40000),
            new Battery(500, 21000)
        };
        protected override Car BuildCar(string ownerName, int model, int engine, int specialModule)
        {
            double price = models[model].Price + engines[engine].Price + batteries[specialModule].Price;
            return new ElectricCar(ownerName, models[model].Name, engines[engine].Name, batteries[specialModule].Capacity, price);
        }

        protected override int ChooseModel()
        {
            System.Console.WriteLine("--Choose Model--");
            for (int i = 0; i < models.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}: {models[i].ShowSpecification()}");
            }
            int choice = -1;
            while (choice < 1 || choice > models.Count)
            {
                choice = GetChoice();
            }
            return choice - 1;
        }

        protected override int ChooseEngine()
        {
            System.Console.WriteLine("--Choose Engine--");
            for (int i = 0; i < engines.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}: {engines[i].ShowSpecification()}");
            }
            int choice = -1;
            while (choice < 1 || choice > engines.Count)
            {
                choice = GetChoice();
            }
            return choice - 1;
        }

        protected override int ChooseSpecialModule()
        {
            System.Console.WriteLine("--Choose Special Module--");
            for (int i = 0; i < batteries.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}: {batteries[i].ShowSpecification()}");
            }
            int choice = -1;
            while (choice < 1 || choice > batteries.Count)
            {
                choice = GetChoice();
            }
            return choice - 1;
        }
    }
}