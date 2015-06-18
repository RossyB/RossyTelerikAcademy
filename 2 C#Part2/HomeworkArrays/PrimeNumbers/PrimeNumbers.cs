using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        bool[] array = new bool[10000001];

        int max = (int)Math.Sqrt(array.Length);

        for (int i = 2; i <= max; i++)
        {
            if (array[i] == false)
            {
                for (int j = i * i; j < array.Length; j = j + i)
                {
                    array[j] = true;
                }
            }
        }
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == false)
            {
                Console.Write(i + " ");
            }
        }
    }
}
