using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortingArray
{
    static void Main()
    {
        int[] array = { 2, 6, 3, 9, 6, 5, 3, 4, 4, 9, 6, 1, 8, 5, 6 };

        SortDescending(array);

        Console.WriteLine(string.Join(", ", array));

        Array.Reverse(array);

        Console.WriteLine(string.Join(", ", array));

    }

    static void SortDescending(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int maxIndex = FindMaxIndexInArray(numbers, i);
            int temp = numbers[i];
            numbers[i] = numbers[maxIndex];
            numbers[maxIndex] = temp;
        }
    }




    static int FindMaxIndexInArray(int[] array, int index)
    {
        int maxElement = int.MinValue;
        int maxIndex = index;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;

    }
}
