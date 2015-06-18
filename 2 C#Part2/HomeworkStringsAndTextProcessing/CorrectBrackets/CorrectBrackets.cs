//Write a program to check if in a given expression the brackets are put correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter the expresion: ");
        string input = Console.ReadLine();

        bool result = CheckBrakets(input);

        if (result)
        {
            Console.WriteLine("The expression is corect!");
        }
        else
        {
            Console.WriteLine("The expression is not corect!");
        }
    }

    private static bool CheckBrakets(string input)
    {
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                count++;
            }
            if (input[i] == ')')
            {
                count--;
            }
            if (count < 0)
            {
                return false;
            }
        }
        if (count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    
    }

}
