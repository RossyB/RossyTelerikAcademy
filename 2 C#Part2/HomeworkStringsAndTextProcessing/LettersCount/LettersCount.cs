//Write a program that reads a string from the console and prints all different letters in 
//the string along with information how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LettersCount
{
    static void Main()
    {
        string input = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
        
        var result = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!result.ContainsKey(input[i]) && char.IsLetter(input[i]))
            {
                result.Add(input[i], 1);
            }
            else if (result.ContainsKey(input[i]) && char.IsLetter(input[i]))
            {
                result[input[i]] += 1;
            }
        }
        Console.WriteLine();

        foreach (var letter in result)
        {
            Console.WriteLine("Letter {0} -> {1} time(s)", letter.Key, letter.Value);
        }

    }
}
