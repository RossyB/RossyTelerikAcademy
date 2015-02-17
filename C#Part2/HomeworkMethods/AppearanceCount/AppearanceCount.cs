//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class AppearanceCount
{
    static void Main()
    {
        int[] numbers = { 2, 5, 8, 5, 7, 8, 4, 3, 5, 3, 5, 8, 2, 5, 8, 8, 4 };

        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        int count = CheckNumber(numbers, n);

        Console.WriteLine("The number {0} is found {1} times", n, count);

    }

    static int CheckNumber(int[] array, int number) 
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        return count;
    }
}
