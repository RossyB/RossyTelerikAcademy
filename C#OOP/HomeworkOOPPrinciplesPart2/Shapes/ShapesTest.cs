namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class ShapesTest
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Rectangle(3, 6));
            shapes.Add(new Triangle(7, 4));
            shapes.Add(new Square(6));
            shapes.Add(new Rectangle(6, 8));
            shapes.Add(new Triangle(3.6, 4));
            shapes.Add(new Square(5.5));

            foreach (var shape in shapes)
            {
                double surface = shape.CalculateSurface();
                Console.WriteLine("{0}, width: {1}, height: {2}, Surface: {3:F2}", 
                    shape.GetType().Name, shape.Width, shape.Height, surface);
            }
        }
    }
}
