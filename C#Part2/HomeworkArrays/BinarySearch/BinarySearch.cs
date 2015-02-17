//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        int[] array = { 3, 8, 16, 18, 19, 25, 28, 32, 39, 45, 63, 67, 87, 99, 103, 203, 333 };

        int indexMin = 0;
        int indexMax = array.Length - 1;
        int indexMiddle;

        bool search = true;

        Console.Write("Enter the number: ");
        int searchKey = int.Parse(Console.ReadLine());

        while (search && indexMax >= indexMin)
        {
            indexMiddle = indexMin / 2 + indexMax / 2;

            if (array[indexMiddle] < searchKey)
            {
                indexMin = indexMiddle + 1;
            }
            else if (array[indexMiddle] > searchKey)
            {
                indexMax = indexMiddle - 1;
            }
            else
            {
                Console.WriteLine("The position of the searching key {0} is: {1}", searchKey, indexMiddle);
                search = false;
            }
        }
        if (indexMin >= indexMax && search == true)
        {
            Console.WriteLine("The key is not found!");
        }

    }
}
