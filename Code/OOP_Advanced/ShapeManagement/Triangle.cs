using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public class Triangle : Shape
    {
        protected double sideA;
        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        protected double sideB;
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        protected double sideC;
        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public Triangle() : base("Triangle")
        {
            type = "Triangle";
        }

        public Triangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetArea()
        {
            double P = GetPerimeter() / 2;
            return Math.Sqrt(P * (P - sideA) * (P - sideB) * (P - sideC));
        }

        public override double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine($"Side: A-{sideA} B-{sideB} C-{sideC}");
        }
    }
}