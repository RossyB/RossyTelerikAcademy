//Write a program that finds the maximal increasing sequence in an array.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] array = { 3, 2, 3, 2, 3, 4, 5 };

        int leng = 1;
        int bestLeng = 0;
        int lengIndex = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                leng++;
            }
            else
            {
                if (leng > bestLeng)
                {
                    bestLeng = leng;
                    lengIndex = i;
                }
                leng = 1;
            }
        }
        if (leng > bestLeng)
        {
            bestLeng = leng;
            lengIndex = array.Length - 1;
        }
        for (int i = lengIndex - bestLeng + 1; i < lengIndex + 1; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

    }
}