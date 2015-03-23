//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter some numbers separated by space: ");
        string input = Console.ReadLine();

        int result = SumString(input);

        Console.WriteLine("The sum of the numbers is: {0}", result);
    }

    static int SumString(string input)
    { 
        int sum = 0;

        string[] numbers = input.Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + int.Parse(numbers[i]);
        }
        return sum;
    }
}
