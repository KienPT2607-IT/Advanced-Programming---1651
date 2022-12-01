using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle()
        {
            radius = 0; // By default
            type = "Circle";
        }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
            type = "Circle";
        }

        public override double GetArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine($"Radius: {radius}\n");
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}