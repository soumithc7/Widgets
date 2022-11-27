using System;
namespace Spreadex.Widgets.Shapes
{
    public abstract class Shape
    {
        private int _x;
        private int _y;

        // constructor 
        public Shape(int x, int y)
        {
            _x = x;
            _y = y;
        }

        //get locations
        public int getX()
        {
            return _x;
        }
        public int getY()
        {
            return _y;
        }

        //move to a specfic location
        public void moveTo(int newX, int newY)
        {
            _x = newX;
            _y = newY;
        }

        //move by a specific amount
        public void moveBy(int deltaX, int deltaY)
        {
            moveTo(getX() + deltaX, getY() + deltaY);
        }

        //draw shape
        public abstract void draw();
    }
}

