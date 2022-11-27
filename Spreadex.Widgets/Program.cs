using System;
using System.Collections.Generic;
using Spreadex.Widgets.Shapes;

namespace Spreadex.Widgets
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapesToDraw = new List<Shape>();

            shapesToDraw.Add(new Rectangle(10, 10, 30, 40));
            shapesToDraw.Add(new Square(15, 30, 35));
            shapesToDraw.Add(new Ellipse(100, 150, 300, 200));
            shapesToDraw.Add(new Circle(1, 1, 300));
            shapesToDraw.Add(new Textbox(5, 5, 200, 100, "sample text"));

            Console.WriteLine("-----------------");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("-----------------");

            foreach (var shape in shapesToDraw)
            {
                shape.draw();
            }
        }
    }
}