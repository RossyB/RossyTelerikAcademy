//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        //input
        Console.Write("Enter side A of the trapezoid: ");
        float sideA = float.Parse(Console.ReadLine());
        Console.Write("Enter side B of the trapezoid: ");
        float sideB = float.Parse(Console.ReadLine());
        Console.Write("Enter height H of the trapezoid: ");
        float heihgt = float.Parse(Console.ReadLine());

        //solution

        float trapezoidArea =  ((sideA + sideB) * heihgt) / 2;

        //print
        Console.WriteLine("Trapezoids area is: {0}", trapezoidArea);
    }
}

