//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DayOfWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        var dayOfWeek = today.DayOfWeek;

        Console.WriteLine("Today {0}.{1}.{2} is {3}", today.Day, today.Month, today.Year, dayOfWeek);

    }
}
