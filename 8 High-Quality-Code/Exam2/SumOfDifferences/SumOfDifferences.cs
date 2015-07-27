using System;
using System.Numerics;

public class SumOfDifferences
{
    public static BigInteger FindAbsoluteDifference(BigInteger previousNumber, BigInteger number)
    {
        if (previousNumber > number)
        {
            return previousNumber - number;
        }
        else if (previousNumber == number)
        {
            return 0;
        }
        else
        {
            return number - previousNumber;
        }
    }

    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        BigInteger[] numbers = new BigInteger[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = BigInteger.Parse(input[i]);
        }

        int indexNumber = 1;
        BigInteger absoluteDifference;
        BigInteger sumOfAbsoluteDifference = 0;

        while (true)
        {
            absoluteDifference = FindAbsoluteDifference(numbers[indexNumber - 1], numbers[indexNumber]);

            if (absoluteDifference % 2 == 0)
            {
                indexNumber += 2;
            }
            else
            {
                indexNumber += 1;
                sumOfAbsoluteDifference += absoluteDifference;
            }

            if (indexNumber >= numbers.Length)
            {
                break;
            }
        }

        Console.WriteLine(sumOfAbsoluteDifference);
    }
}
