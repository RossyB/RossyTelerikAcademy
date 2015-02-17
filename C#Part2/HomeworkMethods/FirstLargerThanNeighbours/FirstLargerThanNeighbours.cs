//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 2, 5, 8, 5, 7, 8, 4, 3, 5, 3, 5, 8, 2, 5, 8, 8, 4 };

        int index = ReturnIndexFirstBiggerElement(numbers);

            if (index != -1)
            {
                Console.WriteLine("Number {0} at position {1} is first bigger number than neighbours.", numbers[index], index);
            }
            else
            {
                Console.WriteLine("There is no such element");
            }

    }

    static int ReturnIndexFirstBiggerElement(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            bool isBigger = IsBiggerNumber(array, i);
            if (isBigger)
            {
                return i;
            }
        }
        return -1;
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
