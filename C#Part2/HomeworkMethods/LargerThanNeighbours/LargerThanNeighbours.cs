//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 2, 5, 8, 5, 7, 8, 4, 3, 5, 3, 5, 8, 2, 5, 8, 8, 4 };

        Console.Write("Enter the position: ");
        int index = int.Parse(Console.ReadLine());

        if (IsBiggerNumber(numbers, index))
        {
            Console.WriteLine("The number {0} is bigger than its neighbors", numbers[index]);
        }
        else
        {
            Console.WriteLine("The number {0} is not bigger than its neighbors", numbers[index]);
        }

    }

    static bool IsBiggerNumber(int[] array, int index)
    {
        bool isBigger = false;

        if (index == 0)
        {
            if (array[index] > array[index + 1])
            {
                isBigger = true;
            }
        }
        else if (index == array.Length - 1)
        {
            if (array[index] > array[index - 1])
            {
                isBigger = true;
            }
        }
        else if (array[index] > array[index + 1] && array[index] > array[index - 1])
        {
            isBigger = true;
        }

        return isBigger;
    }
}
