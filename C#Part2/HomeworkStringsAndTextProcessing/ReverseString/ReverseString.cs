//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        char[] input = Console.ReadLine().ToCharArray();

        Array.Reverse(input);

        Console.WriteLine(input);
    }
}
