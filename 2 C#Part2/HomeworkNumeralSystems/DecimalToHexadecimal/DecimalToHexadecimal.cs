//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string HexadecimalNumber = "";
        string result = "";

        while (decimalNumber > 0)
        {
            HexadecimalNumber = GetChar(decimalNumber % 16) + HexadecimalNumber;
            decimalNumber /= 16;
        }

        Console.WriteLine("Hexadecimal number is: {0}", HexadecimalNumber);
    }

    static char GetChar(int i) 
    {

        if (i >= 10)
        {
            return (char)('A' + i - 10);
        }
        else
        {
            return (char)('0' + i);
        }
    }
}
