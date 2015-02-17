using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter array {0}: ", i);
            array[i] = Console.ReadLine();
        }

        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine(string.Join(" ", array));
    }
}
