//Write a program that reads a string from the console and lists all different words in the string 
//along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class WordsCount
{
    static void Main()
    {
        string input = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        var result = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (!result.ContainsKey(words[i]))
            {
                result.Add(words[i], 1);
            }
            else if (result.ContainsKey(words[i]))
            {
                result[words[i]] += 1;
            }
        }
        Console.WriteLine();

        foreach (var word in result)
        {
            Console.WriteLine("Letter {0} -> {1} time(s)", word.Key, word.Value);
        }

    }
}
