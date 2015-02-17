//Write a method that reverses the digits of given decimal number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseNumber
{
    static void ReverseIntNumber(int number)
    {
        while (number != 0)
        {
            int digit = number % 10;
            number = number / 10;
            Console.Write(digit);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        ReverseIntNumber(number);
    }
}
