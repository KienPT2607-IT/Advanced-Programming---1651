namespace FigureSystem
{
    public abstract class Figure
    {
        public abstract void Draw();
        protected void DrawLine(int n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}