using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FigureSystem
{
    public class Rectangle : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int height, int width)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            for (var i = 0; i < Height; i++)
            {
                DrawLine(Width);
            }
        }
    }
}