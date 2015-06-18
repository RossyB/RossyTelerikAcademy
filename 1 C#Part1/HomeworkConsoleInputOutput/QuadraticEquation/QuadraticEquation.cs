//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter coefficient a: ");
        double coeffA = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double coeffB = double.Parse(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double coeffC = double.Parse(Console.ReadLine());

        double D = (coeffB * coeffB) - 4 * (coeffA * coeffC);
        

        if (D < 0)
        {
            Console.WriteLine("The quadratic equation has no real roots!");           
        }
        else if (D == 0)
        {
            double x = -coeffB / (2 * coeffA);
            Console.WriteLine("The quadratic equation has one real root: x = {0}", x);
        }
        else if (D > 0)
        {
            double x1 = (-coeffB - Math.Sqrt(D)) / (2 * coeffA);
            double x2 = (-coeffB + Math.Sqrt(D)) / (2 * coeffA);
            Console.WriteLine("The quadratic equation has two real roots: x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}

