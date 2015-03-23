//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexadecimalNumber = Console.ReadLine().ToUpper();

        int result = 0;
        int power = hexadecimalNumber.Length - 1;

        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            result = result + GetNumber(hexadecimalNumber, i) * (int)(Math.Pow(16, power));
            power--;
        }

        Console.WriteLine("Decimal number is: {0}", result);
    }

    static int GetNumber(string digit, int i)
    {
        if (digit[i] >= 'A')
        {
            return digit[i] - 'A' + 10;
        }
        else
        {
            return digit[i] - '0';
        }
    
    }
}
