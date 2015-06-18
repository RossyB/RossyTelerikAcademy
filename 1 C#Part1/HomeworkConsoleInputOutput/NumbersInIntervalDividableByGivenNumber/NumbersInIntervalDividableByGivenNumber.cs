//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such 
//that the reminder of the division by 5 is 0.

using System;
using System.Collections.Generic;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two positive numbers n and m (n < m)");
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number m: ");
        int m = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = n; i <= m; i++)
        {
            if (i % 5 == 0)
            {
                numbers.Add(i);
            }
        }

        Console.WriteLine("The numbers between {0} and {1} that are divisible by 5 is: {2}", n, m, numbers.Count);
        Console.WriteLine(string.Join(", ", numbers));
    }
}
