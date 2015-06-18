//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractE_mails
{
    static void Main()
    {
        string str = @"Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

        string[] splittedStr = str.Split(' ');

        for (int i = 0; i < splittedStr.Length; i++)
        {
            if (Regex.IsMatch(splittedStr[i], @"\w+@\w+\.[\w+]{2}"))
            {
                Console.WriteLine("{0} is a valid email", splittedStr[i]);
            }
        }
    }
}
