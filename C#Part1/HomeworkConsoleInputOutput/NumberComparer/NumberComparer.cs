//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the number a: ");
        float numberA = float.Parse(Console.ReadLine());
        Console.Write("Enter the number b: ");
        float numberB = float.Parse(Console.ReadLine());

        float maxNumber = Math.Max(numberA, numberB);

        Console.WriteLine("The greater of the numbers is: {0}", maxNumber);
    }
}

