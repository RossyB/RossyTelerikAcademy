//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = "Hi, I'm fine.";

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            result.Append(String.Format("\\u{0:X4}", (int)input[i]));
        }
        Console.WriteLine(result.ToString());

    }
}
