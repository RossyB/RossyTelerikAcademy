//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter number 1: "); 
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter number 2: "); 
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter number 3: "); 
        float c = float.Parse(Console.ReadLine());
        Console.Write("Enter number 4: "); 
        float d = float.Parse(Console.ReadLine());
        Console.Write("Enter number 5: "); 
        float e = float.Parse(Console.ReadLine());

        float max = a;

        if (max < b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        if (max < d)
        {
            max = d;
        }
        if (max < e)
        {
            max = e;
        }
        Console.WriteLine("The biggest of numbers {0}, {1}, {2}, {3}, {4} is: {5}", a, b, c, d, e, max);

    }
}
