//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder str = new StringBuilder(input);

        for (int letter = 0; letter < str.Length - 1; letter++)
        {
            if (str[letter] == str[letter + 1])
            {
                str.Remove(letter, 1);
                letter--;
            }
        }
        Console.WriteLine(str);
    }
}
