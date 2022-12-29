using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCustomizingSystem
{
    public class SuperCarCustomizing : CarCustomizing
    {
        private static List<Engine> engines = new List<Engine>()
        {
            new Engine("The Roma's 3.9-litre turbo V8", 1500, 2000000),
            new Engine("Audi Turbocharged 2.5-Liter Inline-Five", 400, 56400),
            new Engine("BMW Twin-Turbo 4.4-Liter V8", 617, 125000),
            new Engine("Ferrari Twin-Turbocharged 3.9-Liter V8", 710, 132456)
        };
        private static List<Nitro> nitro = new List<Nitro>()
        {
            new Nitro("Nitrous A", 200, 3000),
            new Nitro("Nitrous B", 300, 4000),
            new Nitro("Nitrous C", 400, 5000)
        };

        private static List<Model> models = new List<Model>()
        {
            new Model("Bugatti Chiron Sport", 3400000),
            new Model("Lamborghini Countach", 1560000),
            new Model("Porsche 918 Spyder", 2530000),
            new Model("Mercedes-Benz SLS AMG Black Series", 530000),
            new Model("Lamborghini Murcielago", 900023)
        };
        protected override Car BuildCar(string ownerName, int model, int engine, int specialModule)
        {
            double price = (models[model].Price + engines[engine].Price + nitro[specialModule].Price) * (VAT + WAGE);
            return new SuperCar(ownerName, models[model].Name, engines[engine].Name, nitro[specialModule].Name, price);
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
            for (int i = 0; i < nitro.Count; i++)
            {
                System.Console.WriteLine($"{i + 1}: {nitro[i].ShowSpecification()}");
            }
            int choice = -1;
            while (choice < 1 || choice > nitro.Count)
            {
                choice = GetChoice();
            }
            return choice - 1;
        }
    }
}