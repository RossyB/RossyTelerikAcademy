//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter the number n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter integer number {0}: ", i+1);
            numbers[i] = int.Parse(Console.ReadLine()); 
        }

        int maxNumber = Int32.MinValue;
        int minNumber = Int32.MaxValue;
        int sumNumbers = 0;
        double avgNumbers = 0.0;

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }

            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }

            sumNumbers += numbers[i];
        }

        avgNumbers = (float)sumNumbers / n;

        Console.WriteLine("min = {0}", minNumber);
        Console.WriteLine("max = {0}", maxNumber);
        Console.WriteLine("sum = {0}", sumNumbers);
        Console.WriteLine("avg = {0:F2}", avgNumbers);
    }
}

