using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public abstract class Shape
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected string type;
        public string Type
        {
            get { return type; }
        }
        public Shape()
        {
            Name = "a default shape";
            type = "Shape";
        }

        public Shape(string name)
        {
            type = "Shape";
            Name = name;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public virtual void ShowInfor()
        {
            System.Console.WriteLine($"Shape name: {name}");
            System.Console.WriteLine($"Type: {type}");
            System.Console.WriteLine($"Area: {GetArea()}");
            System.Console.WriteLine($"Perimeter: {GetPerimeter()}");
        }
    }
}