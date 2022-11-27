using System;
namespace Spreadex.Widgets.Shapes
{
    public class Ellipse : Shape
    {
        private int _diameterH;
        private int _diameterV;

        public Ellipse(int x, int y, int diameterH, int diameterV) : base(x, y)
        {
            _diameterH = diameterH;
            _diameterV = diameterV;
        }

        public int getDiameterH()
        {
            return _diameterH;
        }
        public int getDiameterV()
        {
            return _diameterV;
        }

        public override void draw()
        {
            Console.WriteLine("Ellipse ({0}, {1}) diameterH={2} diameterV={3}",
                getX(), getY(), getDiameterH(), getDiameterV());
        }
    }
}

