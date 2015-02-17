//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArray
{
    static void Main()
    {
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };

        int currentSum = 0;
        Console.Write("Enter sum S: ");
        int sumS = int.Parse(Console.ReadLine());

        string bestSequence = String.Empty;

        for (int i = 0; i < array.Length; i++)
        {
            string currentSequence = String.Empty;

            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];
                currentSequence = currentSequence + array[j] + ' ';

                if (currentSum == sumS)
                {
                    bestSequence = currentSequence;
                }
            }
            currentSum = 0;
        }
        Console.WriteLine("S = {0}   ({1})",sumS, bestSequence );
    }
}
