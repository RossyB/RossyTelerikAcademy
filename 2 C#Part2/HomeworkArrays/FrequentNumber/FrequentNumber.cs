//Write a program that finds the most frequent number in an array.

using System;

class FrequentNumber
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int currentMax;
        int maxCount = 0;
        int maxRepeat = 0;
        int maxNumber = 0;

        for (int i = 0; i < array.Length; i++)
        {
            currentMax = array[i];

            for (int j = 0; j < array.Length; j++)
            {
                if (currentMax == array[j])
                {
                    maxCount++;
                }
            }
            if (maxCount > maxRepeat)
            {
                maxRepeat = maxCount;
                maxNumber = currentMax;
                maxCount = 0;
            }
            maxCount = 0;
        }
            
        Console.WriteLine("{0} ({1} times)", maxNumber, maxRepeat);
    }
}