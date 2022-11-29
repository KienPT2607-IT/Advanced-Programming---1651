using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public class ShapeProgram : MenuProgram
    {
        private List<Shape> shapes;

        public ShapeProgram()
        {
            shapes = new List<Shape>();
        }

        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Add circle");
            System.Console.WriteLine("2. Add Rectangle");
            System.Console.WriteLine("3. Add Square");
            System.Console.WriteLine("4. Show all shapes");
            System.Console.WriteLine("0. Exit");
        }

        protected override void Process(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddCircle();
                    break;
                case 2:
                    AddRectangle();
                    break;
                case 3:
                    AddSquare();
                    break;
                case 4:
                    ShowAllShape();
                    break;
                case 0:
                    System.Console.WriteLine("The program terminated\n");
                    break;
                default:
                    break;
            }
        }

        private void ShowAllShape()
        {
            foreach (Shape shp in shapes)
            {
                shp.ShowInfor();
            }
        }

        private void AddSquare()
        {
            Console.Write("Circle name: ");
            string name = Console.ReadLine();
            Console.Write("side: ");
            double side = double.Parse(Console.ReadLine());
            shapes.Add(new Square(name, side));
        }

        private void AddRectangle()
        {
            Console.Write("Circle name: ");
            string name = Console.ReadLine();
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(name, width, height));
        }

        private void AddCircle()
        {
            Console.Write("Circle name: ");
            string name = Console.ReadLine();
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            shapes.Add(new Circle(name, radius));
        }
    }
}