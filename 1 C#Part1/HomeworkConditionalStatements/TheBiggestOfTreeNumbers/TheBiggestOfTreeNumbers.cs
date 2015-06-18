//Write a program that finds the biggest of three numbers.

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfTreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());

        double maxNumber = Math.Max(Math.Max(a, b), c);

        Console.WriteLine("The max number is: {0}", maxNumber);

    }
}
