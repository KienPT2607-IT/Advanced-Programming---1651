using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FigureSystem
{
    public class Triangle : Figure
    {
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Triangle(int height)
        {
            Height = height;
        }
        public override void Draw()
        {
            for (var i = 0; i <= height; i++)
            {
                DrawLine(height);
            }
        }
    }
}