//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).


using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int second = int.Parse(Console.ReadLine());

        int remainder;
        while (second != 0)
        {
            remainder = first % second;
            first = second;
            second = remainder;
        }
        Console.WriteLine("GSD: {0}", first);
        

    }
}
