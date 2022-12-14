using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextSystem;
namespace FigureSystem
{
    public class TextFigure : Figure
    {
        private TextBox textBox;
        public TextFigure(string text)
        {
            textBox = new TextBox(text);
        }
        public override void Draw()
        {
            textBox.Print();
        }
    }
}