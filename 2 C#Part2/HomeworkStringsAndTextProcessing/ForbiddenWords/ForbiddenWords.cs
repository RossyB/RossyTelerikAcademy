﻿//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        
        string[] words = {"PHP", "CLR", "Microsoft"};

        for (int i = 0; i < words.Length; i++)
		{
		        text = text.Replace(words[i] , new String ('*', words[i].Length));
		}
        Console.WriteLine(text);
    }
}
