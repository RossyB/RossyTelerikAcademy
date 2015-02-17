//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        int[] array = { 31, 34, 12, 22, 11, 16, 6, 19, 90, 122, 18, 72, 63 };

        int minIndex;
        int tempNum;

        for (int i = 0; i < array.Length - 1; i++)
        {
            minIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            tempNum = array[i];
            array[i] = array[minIndex];
            array[minIndex] = tempNum;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}
