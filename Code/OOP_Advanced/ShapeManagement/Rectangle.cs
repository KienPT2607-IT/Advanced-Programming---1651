using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public class Rectangle : Shape
    {
        protected double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        protected double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle()
        {
            width = height = 1;
            type = "Rectangle";
        }

        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
            type = "Rectangle";
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine($"Width: {width}");
            System.Console.WriteLine($"height: {height}\n");
        }
    }
}