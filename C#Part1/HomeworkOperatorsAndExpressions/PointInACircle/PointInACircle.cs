//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enrer point x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enrer point y: ");
        double y = double.Parse(Console.ReadLine());

        double circleRadius = 2;

        bool isInCircle = (x * x) + (y * y) <= circleRadius * circleRadius;

        if (isInCircle == true)
        {
            Console.WriteLine("The point is in the circle.");
        }
        else
        {
            Console.WriteLine("The point is not in the circle.");
        }
    }
}
