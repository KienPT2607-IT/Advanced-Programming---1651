using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public class IsoscelesTriangle : Triangle
    {
        public double Base { get; set; }
        protected double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public IsoscelesTriangle()
        {
            name = "Isosceles Triangle";
            type = "Isosceles Triangle";
        }

        public IsoscelesTriangle(string name, double _base, double side) : base(name, side, side, _base)
        {
            type = "Isosceles Triangle";
        }
    }
}