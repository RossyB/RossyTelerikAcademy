//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the circle radius: ");
        double radius = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * (radius * radius);
        double circlePerimeter = 2 * Math.PI * radius;

        Console.WriteLine("The perimeter of the circle is: {0:F2}", circlePerimeter);
        Console.WriteLine("The area of the circle is: {0:F2}", circleArea);
    }
}
