//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<')
            {
                i += 8;
                while (input[i] != '<')
                {
                    result.Append(input[i].ToString().ToUpper());
                    i++;
                }
                i += 8;
            }
            else
            {
                result.Append(input[i]);
            }
        }

        Console.WriteLine("The result is: {0}", result);

    }
}
