using System;

class CalculateFacttorialDivision
{
    static void Main()
    {
        Console.WriteLine("Enter numbers n and k where (1 < k < n < 100)");
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number k: ");
        int k = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;

            if (i > k)
            {
                continue;
            }
            else
            {
                factorialK *= i;
            }
        }

        long division = factorialN / factorialK;

        Console.WriteLine(division);
    }
}
