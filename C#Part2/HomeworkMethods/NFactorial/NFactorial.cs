using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class NFactorial
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = Enumerable.Range(1, n).ToArray();
        BigInteger[] factorial = new BigInteger[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            factorial[i] = CalculateNFactorial(i + 1);
        }

        PrintArray(factorial);
    }

    static void PrintArray(BigInteger[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Factorial of {0} is : {1}", i + 1, array[i]);
        }
    }

    static BigInteger CalculateNFactorial(int n)
    {
        BigInteger factorialN = 1;

        for (int i = 1; i <= n; i++) 
        {
            factorialN *= i;
        }
        return factorialN;
    }
}
