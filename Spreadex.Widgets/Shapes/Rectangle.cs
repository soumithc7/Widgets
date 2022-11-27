using System;
namespace Spreadex.Widgets.Shapes
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            _width = width;
            _height = height;
        }

        public int getWidth()
        {
            return _width;
        }
        public int getHeight()
        {
            return _height;
        }

        public override void draw()
        {
            Console.WriteLine("Rectangle ({0}, {1}) width={2} height={3}",
                getX(), getY(), getWidth(), getHeight());
        }
    }
}

