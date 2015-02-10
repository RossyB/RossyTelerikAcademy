//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).


using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter number where (1 < n < 100): ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial2N = 1;
        BigInteger factorialN = 1;
        BigInteger factorialNPlusOne = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            factorial2N *= i;

            if (i <= n)
            {
                factorialN *= i;
            }

            if (i <= n + 1)
            {
                factorialNPlusOne *= i;                
            }
        }

        BigInteger result = factorial2N / (factorialNPlusOne * factorialN);

        Console.WriteLine(result);
    }
}
