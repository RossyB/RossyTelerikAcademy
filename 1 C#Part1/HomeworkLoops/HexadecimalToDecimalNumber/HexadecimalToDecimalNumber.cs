//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.


using System;
using System.Collections.Generic;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter Hexadecimal value: ");
        string hex = Console.ReadLine().Trim();

        long result = 0;
        hex = hex.ToLower();

        Dictionary<char, int> hexdecval = new Dictionary<char, int>{
            {'0', 0},
            {'1', 1},
            {'2', 2},
            {'3', 3},
            {'4', 4},
            {'5', 5},
            {'6', 6},
            {'7', 7},
            {'8', 8},
            {'9', 9},
            {'a', 10},
            {'b', 11},
            {'c', 12},
            {'d', 13},
            {'e', 14},
            {'f', 15},
        };

        for (int i = 0; i < hex.Length; i++)
        {
            char valAt = hex[hex.Length - 1 - i];
            result += hexdecval[valAt] * (long)Math.Pow(16, i);
        }

        Console.WriteLine(result);

    }
}
