using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IntegerCalculations
{
    static void Main()
    {
        int min = Min(6, 3, 2);
        int max = Max(6, 3, 2);
        int sum = Sum(6, 3, 2);
        int average = Average(6, 3, 2);
        int product = Product(6, 3, 2);

        Console.WriteLine("Min: {0}", min);
        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Average: {0}", average);
        Console.WriteLine("Product: {0}", product);
    }

    static int Min(params int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static int Max(params int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static int Sum(params int[] array)
    {
        int sum = 0;
        foreach (int x in array)
        {
            sum += x;
        }
        return sum;
    }

    static int Average(params int[] array)
    {
        int sum = 0, arrayLength = array.GetLength(0);
        foreach (int x in array)
        {
            sum += x;
        }

        return sum / arrayLength;
    }

    static int Product(params int[] array)
    {
        int product = 1;
        foreach (int x in array)
        {
            product *= x;
        }

        return product;
    }
}
