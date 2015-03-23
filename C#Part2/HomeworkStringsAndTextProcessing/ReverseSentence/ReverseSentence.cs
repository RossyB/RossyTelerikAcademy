//Write a program that reverses the words in given sentence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ReverseSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";

        string regex = @"\s+|,\s*|\.\s*|!\s*";

        List<string> words = new List<string>();

        List<string> separators = new List<string>();

        foreach (string word in Regex.Split(sentence, regex))
            words.Add(word);

        foreach (Match separator in Regex.Matches(sentence, regex))
            separators.Add(separator.Value);

        for (int i = 0; i < separators.Count; i++)
            Console.Write(words[words.Count - 2 - i] + separators[i]);

        Console.WriteLine();

    }
}
