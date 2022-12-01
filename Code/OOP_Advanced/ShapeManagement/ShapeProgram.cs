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
            System.Console.WriteLine("4. Add Triangle");
            System.Console.WriteLine("5. Show all shapes");
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
                    AddTriangleMenu();
                    int _choice = GetChoice();
                    AddTriangleProcess(_choice);
                    break;
                case 5:
                    ShowAllShape();
                    break;
                case 0:
                    System.Console.WriteLine("The program terminated\n");
                    break;
                default:
                    break;
            }
        }

        private void AddTriangleMenu()
        {
            System.Console.WriteLine("1. Normal");
            System.Console.WriteLine("2. Isosceles");
            System.Console.WriteLine("3. Equilateral");
            System.Console.WriteLine("others: Exit to main menu\n");
        }

        private void AddTriangleProcess(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddNormalTriangle();
                    break;
                case 2:
                    AddIsoTriangle();
                    break;
                case 3:
                    AddEquilTriangle();
                    break;
                default:
                    break;
            }
        }

        private void AddEquilTriangle()
        {
            Console.Write("Equilateral Triangle name: ");
            string name = Console.ReadLine();
            Console.Write("Side: ");
            double side = double.Parse(Console.ReadLine());
            shapes.Add(new EquilateralTriangle(name, side));
        }

        private void AddIsoTriangle()
        {
            Console.Write("Isosceles Triangle name: ");
            string name = Console.ReadLine();
            Console.Write("Base: ");
            double _base = double.Parse(Console.ReadLine());
            Console.Write("side: ");
            double side = double.Parse(Console.ReadLine());
            shapes.Add(new IsoscelesTriangle(name, _base, side));
        }

        private void AddNormalTriangle()
        {
            Console.Write("Normal Triangle name: ");
            string name = Console.ReadLine();
            Console.Write("Side A: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Side B: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Side C: ");
            double sideC = double.Parse(Console.ReadLine());
            shapes.Add(new Triangle(name, sideA, sideB, sideC));
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
            Console.Write("Square name: ");
            string name = Console.ReadLine();
            Console.Write("side: ");
            double side = double.Parse(Console.ReadLine());
            shapes.Add(new Square(name, side));
        }

        private void AddRectangle()
        {
            Console.Write("Rectangle name: ");
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