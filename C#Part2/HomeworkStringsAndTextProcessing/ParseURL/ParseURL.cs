//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
//and extracts from it the [protocol], [server] and [resource] elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string url = @"http://telerikacademy.com/Courses/Courses/Details/212";

        var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine(@"[protokol] = ""{0}""", fragments[1]);
        Console.WriteLine(@"[server] = ""{0}""", fragments[2]);
        Console.WriteLine(@"[resource] = ""{0}""", fragments[3]);

    }
}
