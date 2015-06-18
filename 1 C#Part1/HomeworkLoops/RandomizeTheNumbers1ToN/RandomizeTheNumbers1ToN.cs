//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        int randomIndex = 0;
        bool[] isPrinted = new bool[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        Random number = new Random();

        for (int i = 0; i < n; i++)
        {
            randomIndex = number.Next(0, n);

            if (isPrinted[randomIndex] == false)
            {
                Console.Write(numbers[randomIndex] + " ");
                isPrinted[randomIndex] = true;
            }
            i--;
        }
    }
}
