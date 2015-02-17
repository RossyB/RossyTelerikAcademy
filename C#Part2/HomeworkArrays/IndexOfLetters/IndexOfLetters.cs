//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] charArray = new char[26];

        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = (char)('A' + i);
        }

        Console.Write("Enter the word :");
        string word = Console.ReadLine().ToUpper();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < charArray.Length; j++)
            {
                if (word[i] == charArray[j])
                {
                    Console.WriteLine("letter => {0} : index {1}", word[i], j);
                }
            }
        }

    }
}

