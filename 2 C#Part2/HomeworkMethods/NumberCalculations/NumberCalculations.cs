using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NumberCalculations
{
        static void Main()
    {
        int min = Min(6, 3, 2);
        int max = Max(6, 3, 2);
        int sum = Sum(6, 3, 2);
        int average = Average(6, 3, 2);
        int product = Product(6, 3, 2);

        double min1 = Min(6.2, 3.4, 2.2);
        double max1 = Max(6.2, 3.4, 2.2);
        double sum1 = Sum(6.2, 3.4, 2.2);
        double average1 = Average(6.2, 3.4, 2.2);
        double product1 = Product(6.2, 3.4, 2.2);

        Console.WriteLine("Min: {0}", min);
        Console.WriteLine("Max: {0}", max);
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Average: {0}", average);
        Console.WriteLine("Product: {0}", product);
        Console.WriteLine();
        Console.WriteLine("Min1: {0}", min1);
        Console.WriteLine("Max1: {0}", max1);
        Console.WriteLine("Sum1: {0}", sum1);
        Console.WriteLine("Average1: {0}", average1);
        Console.WriteLine("Product1: {0}", product1);
    }

    static T Min<T>(params T[] array)
    {
        dynamic min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }

    static T Max<T>(params T[] array)
    {
        dynamic max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static T Sum<T>(params T[] array)
    {
        dynamic sum = 0;
        foreach (T x in array)
        {
            sum += x;
        }
        return sum;
    }

    static T Average<T>(params T[] array)
    {
        dynamic sum = 0, sequenceLength = array.GetLength(0);
        foreach (T x in array)
        {
            sum += x;
        }

        return sum / sequenceLength;
    }

    static T Product<T>(params T[] array)
    {
        dynamic product = 1;
        foreach (T x in array)
        {
            product *= x;
        }

        return product;
    }
}
