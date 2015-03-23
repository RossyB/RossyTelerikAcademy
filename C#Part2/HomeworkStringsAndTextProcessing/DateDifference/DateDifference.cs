//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.Write("Enter the second date: ");
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

        int days = (int)(endDate - startDate).TotalDays;

        Console.WriteLine("Distance: {0} days ", days);
    }
}
