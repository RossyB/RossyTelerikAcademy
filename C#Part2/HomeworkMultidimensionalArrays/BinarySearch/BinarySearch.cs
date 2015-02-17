using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter nymber k: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element [0]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        while (Array.BinarySearch(array, k) < 0)
        {
            k--;
        }

        Console.WriteLine("Number in the array which is less or equal to K is " + k);
    }
}
