using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public class Square : Rectangle
    {
        public double Side
        {
            get { return width; }
            set { width = height = value; }
        }

        public Square()
        {
            type = "Square";
        }

        public Square(string name, double side) : base(name, side, side)
        {
            type = "Square";
            Side = side;
        }
    }
}