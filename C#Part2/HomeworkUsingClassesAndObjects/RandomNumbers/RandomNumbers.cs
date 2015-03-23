//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RandomNumbers
{
    static void Main()
    {
        Random RandomGenerator = new Random();
        int[] randomNumbers = new int[10];

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = RandomGenerator.Next(100, 200);  
        }
        Console.WriteLine("These are 10 random numbers between 100 and 200");
        Console.WriteLine(string.Join(", ", randomNumbers));
    }
}
