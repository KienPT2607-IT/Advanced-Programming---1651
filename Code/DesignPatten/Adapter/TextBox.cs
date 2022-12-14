using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextSystem
{
    public class TextBox
    {
        public string Text { get; set; }
        public TextBox(string text)
        {
            Text = text;
        }

        public void Print()
        {
            int n = Text.Length;
            // Draw upper line
            for (int i = 0; i < n + 4; i++)
                Console.Write("*");
            System.Console.WriteLine();
            System.Console.WriteLine("* " + Text + " *");
            for (int i = 0; i < n + 4; i++)
                Console.Write("*");
            System.Console.WriteLine();
        }
    }
}