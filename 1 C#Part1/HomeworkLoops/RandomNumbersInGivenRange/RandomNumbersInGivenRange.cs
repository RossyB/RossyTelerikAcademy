using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());
        Random number = new Random();

        for (int i = 1; i <= n; i++)
        {
            Console.Write(number.Next(min, max) + " ");
        }

    }
}
