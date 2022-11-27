using System;
namespace Spreadex.Widgets.Shapes
{
    public class Square : Shape
    {
        private int _width;

        public Square(int x, int y, int width) : base(x, y)
        {
            _width = width;
        }

        public int getWidth()
        {
            return _width;
        }

        public override void draw()
        {
            Console.WriteLine("Square ({0}, {1}) size={2}",
                getX(), getY(), getWidth());
        }
    }
}

