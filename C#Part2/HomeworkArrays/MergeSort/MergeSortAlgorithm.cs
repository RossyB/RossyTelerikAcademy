//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSortAlgorithm
{
    static void Main()
    {
        int[] arrNumbers = { 1, -1, 2, 3, -3, 4, 67, -4, 5, 16, 12, 17, 34, 92, 40 };
        int[] temp = new int[arrNumbers.Length];

        MergeSort(arrNumbers, temp, 0, arrNumbers.Length - 1);

        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Console.Write(arrNumbers[i] + " ");
        }
    }

    static void MergeSort(int[] array, int[] tmp, int start, int end)
    {
        // Array with 1 element
        if (start >= end) return;

        // Define a middle of the array
        int middle = start + (end - start) / 2;

        MergeSort(array, tmp, start, middle);
        MergeSort(array, tmp, middle + 1, end);

        CompareAndSort(array, tmp, start, middle, end);
    }

    static void CompareAndSort(int[] array, int[] tmp, int start, int middle, int end)
    {
        int left_tmp = start, left_arr = start, middle_arr = middle + 1;

        while (left_arr <= middle && middle_arr <= end)
        {
            if (array[left_arr] > array[middle_arr])
            {
                tmp[left_tmp++] = array[middle_arr++];
            }
            else
            {
                tmp[left_tmp++] = array[left_arr++];
            }
        }

        while (left_arr <= middle)
        {
            tmp[left_tmp++] = array[left_arr++];
        }

        while (middle_arr <= end)
        {
            tmp[left_tmp++] = array[middle_arr++];
        }

        for (int i = start; i <= end; i++)
        {
            array[i] = tmp[i];
        }
    }
}
