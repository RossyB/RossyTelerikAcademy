using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Enter sum of the subsets: ");
        int wantedSum = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of subset: ");
        int wantedNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of elements: ");
        int numberOfElements = int.Parse(Console.ReadLine());

        int[] elements = new int[numberOfElements];

        int counter = 0;
        List<int> subset = new List<int>();

        for (int i = 0; i < elements.Length; i++)
        {
            Console.Write("Enter the element {0}: ", i);
            elements[i] = int.Parse(Console.ReadLine());
        }

        int maxSubsets = (int)Math.Pow(2, numberOfElements) - 1;

        for (int i = 1; i <= maxSubsets; i++)
        {
            subset.Clear();
            int checkingSum = 0;
            for (int j = 0; j <= numberOfElements; j++)
            {
                
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + elements[j];
                    subset.Add(elements[j]);
                }
            }
            if (checkingSum == wantedSum && subset.Count == wantedNumber)
            {
                counter++;
            }
        }
        if (counter > 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}
