using System;
namespace Spreadex.Widgets.Shapes
{
    public class Circle : Shape
    {
        private int _diameter;

        public Circle(int x, int y, int diameter) : base(x, y)
        {
            _diameter = diameter;

        }

        public int getDiameter()
        {
            return _diameter;
        }

        public override void draw()
        {
            Console.WriteLine("Circle ({0}, {1}) size={2}",
                getX(), getY(), getDiameter());
        }
    }
}

