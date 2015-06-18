//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class SumOfTreeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =CultureInfo.InvariantCulture;

        Console.Write("Enter the numer A: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Enter the numer B: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Enter the numer C: ");
        float c = float.Parse(Console.ReadLine());

        float sumOfNumbers = a + b + c;

        Console.WriteLine("The sum of the numbers is: {0}", sumOfNumbers);
    }
}

