//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        //input
        Console.Write("Enter the width of the rectangle: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter the height of the rectangle: ");
        float height = float.Parse(Console.ReadLine());

        //solution
        float perimeter = 2 * width + 2 * height;
        float area = width * height;

        //print
        Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}

