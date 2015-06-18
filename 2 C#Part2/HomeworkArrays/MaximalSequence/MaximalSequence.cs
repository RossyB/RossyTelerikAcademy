//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        int counter = 1;
        int numberOfSequence = 0;
        int maxSequence = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
                numberOfSequence = array[i];
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                }
            }
            else
            {
                counter = 1;
            }
        }

        for (int i = 1; i <= maxSequence; i++)
        {
            if (i < maxSequence)
            {
                Console.Write("{0}, ", numberOfSequence);
            }
            else
            {
                Console.WriteLine("{0}", numberOfSequence);
            }
        }

    }
}
