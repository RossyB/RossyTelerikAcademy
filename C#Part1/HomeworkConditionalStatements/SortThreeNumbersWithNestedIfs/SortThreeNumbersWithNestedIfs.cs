//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.


using System;
using System.Globalization;
using System.Threading;

class SortThreeNumbersWithNestedIfs
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

        if (a > b)
        {
            if (a > c)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else //b < c
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else // a < c
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else // a < b
        {
            if (a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else // a < c
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}
