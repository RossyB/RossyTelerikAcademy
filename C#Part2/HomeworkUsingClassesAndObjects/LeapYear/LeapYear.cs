//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(year);
        if (isLeap)
        {
            Console.WriteLine("The year {0} is Leap.", year);
        }
        else
        {
            Console.WriteLine("The year {0} is not Leap.", year);
        }

    }
}
