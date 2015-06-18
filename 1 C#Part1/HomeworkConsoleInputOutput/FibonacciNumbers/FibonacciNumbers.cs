//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter the number n: ");
        int numberN = int.Parse(Console.ReadLine());

        int[] fibonachiNumbers = new int[numberN];

        for (int i = 0; i < numberN; i++)
        {
            if (i == 0)
            {
                fibonachiNumbers[i] = 0;
            }
            else if (i == 1)
            {
                fibonachiNumbers[i] = 1;
            }
            else
            {
                fibonachiNumbers[i] = fibonachiNumbers[i - 1] + fibonachiNumbers[i - 2];
            }
        }
        Console.WriteLine(string.Join(" ", fibonachiNumbers));
       
    }
}

