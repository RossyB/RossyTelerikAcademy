//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number N: ");
        int numN = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int numK = int.Parse(Console.ReadLine());

        if (numK > numN)
        {
            Console.WriteLine("Number N must be greater than number K");
            return;
        }

        int[] array = new int[numN];
        Console.WriteLine("Enter the elements of the array: ");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        int maxSum = 0;

        string bestSequence = String.Empty;

        for (int i = 0; i < array.Length; i++)
        {
            string currentSequence = String.Empty;

            if (i+numK > array.Length)
            {
                break;
            }

            for (int j = i; j < i + numK; j++)
            {
                currentSum += array[j];
                currentSequence = currentSequence + array[j] + ' ';
            }

            if (currentSum > maxSum)
            {
                bestSequence = currentSequence;
                maxSum = currentSum;
            }
            currentSum = 0;
        }
        Console.WriteLine("The sequence with maximal sum is: {0}", bestSequence);
        Console.WriteLine("The max sum is: {0}", maxSum);
    }
}
