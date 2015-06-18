//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.


using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter integer number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter integer number x: ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;

            sum += factorial / Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}
