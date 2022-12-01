using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public class EquilateralTriangle : IsoscelesTriangle
    {
        public double Side
        {
            get { return side; }
            set { side = Base = value; }
        }

        public EquilateralTriangle()
        {
            name = " Equilateral Triangle";
            type = " Equilateral Triangle";
        }

        public EquilateralTriangle(string name, double side) : base(name, side, side)
        {
            type = " Equilateral Triangle";
        }
    }
}