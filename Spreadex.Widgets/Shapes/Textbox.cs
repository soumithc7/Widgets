using System;
namespace Spreadex.Widgets.Shapes
{
    public class Textbox : Shape
    {
        private int _width;
        private int _height;
        private string _text;

        public Textbox(int x, int y, int width, int height, string text) : base(x, y)
        {
            _width = width;
            _height = height;
            _text = text;

        }

        public int getWidth()
        {
            return _width;
        }
        public int getHeight()
        {
            return _height;
        }
        public string getText()
        {
            return _text;
        }

        public override void draw()
        {
            Console.WriteLine("Textbox ({0}, {1}) width={2} height={3} text={4}",
                getX(), getY(), getWidth(), getHeight(), getText());
        }
    }
}

