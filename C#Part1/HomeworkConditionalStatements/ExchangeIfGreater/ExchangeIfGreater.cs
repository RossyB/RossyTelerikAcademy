//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space.

using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double tempValue = b;
            b = a;
            a = tempValue;
            Console.WriteLine("Exchanged numbers a = {0} b = {1}", a, b);
        }
        else
        {
            Console.WriteLine("Numbers a = {0} b = {1}", a, b);
        }
        
    }
}
