//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OrderWords
{
    static void Main()
    {
        string[] inputWords = Console.ReadLine().Split();

        Array.Sort(inputWords);

        Console.WriteLine(string.Join(", ", inputWords));
    }

}
