//Write a method that returns the last digit of given integer as an English word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        string numberAsString = LastDigitAsString(number);

        Console.WriteLine("Last gigit of number is {0} ", numberAsString);

    }

    static string LastDigitAsString(int number)
    {
        string[] digit = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};

        int lastDigit = number % 10;

        return digit[lastDigit];
           
    }
}
