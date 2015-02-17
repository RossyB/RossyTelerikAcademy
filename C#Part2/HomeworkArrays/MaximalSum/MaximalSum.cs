//Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main()
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int maxSum = 0;
        int currentSum = 0;
        int startSequence = 0;
        int endSequence = 0;
        int start = 0;


        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startSequence = start;
                endSequence = i;
            }

            else if (currentSum < 0)
            {
                start = i + 1;
                currentSum = 0;
            }

            
        }
        for (int i = startSequence; i <= endSequence; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}
