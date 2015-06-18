//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Globalization;
using System.Threading;

class SumOfFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        Console.Write("Enter five numbers on one line separated by space: ");

        string[] numbers = Console.ReadLine().Split(' ');
        double sumOfNumbers = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sumOfNumbers += float.Parse(numbers[i]);
        }
        Console.WriteLine("The sum of the numbers is: {0:F2}", sumOfNumbers);
    }
}
