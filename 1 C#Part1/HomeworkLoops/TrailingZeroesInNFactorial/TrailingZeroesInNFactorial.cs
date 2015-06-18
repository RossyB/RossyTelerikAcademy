//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.


using System;
using System.Numerics;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = 50; //int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }

        string factorialAsString = factorialN.ToString();

        int counter = 0;

        int index = factorialAsString.Length - 1;

        while (factorialAsString[index] == '0')
        {
            counter++;
            index --;
        }
            Console.WriteLine("{0}! is : {1}",n , factorialAsString);
            Console.WriteLine("Trailing zeroes of {0}! is: {1}",n , counter);
    }
}
