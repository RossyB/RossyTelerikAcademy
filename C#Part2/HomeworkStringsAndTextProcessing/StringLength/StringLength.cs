//Write a program that reads from the console a string of maximum 20 characters. If the length of 
//the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter string with maximum 20 characters: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < 20; i++)
        {
            if (i < input.Length)
            {
                result.Append(input[i]);
            }
            else
            {
                result.Append('*');
            }
        }

        Console.WriteLine(result.ToString());
    }
}
