//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());

        string binaryrepresentation = ConvertDecimalToBinary(number);

        Console.WriteLine("Number {0} in bynary system is: {1}", number, binaryrepresentation);

    }
    static string ConvertDecimalToBinary(int decNumber)
    {
        string binaryRepresentation = null;

        if (decNumber < 0)
        {
            decNumber = decNumber ^ int.MinValue;
        }

        if (decNumber != 0)
        {
            while (decNumber > 0)
            {
                int reminder = decNumber % 2;
                binaryRepresentation = reminder + binaryRepresentation;
                decNumber /= 2;
            }
            return binaryRepresentation;
        }
        else
        {
            return decNumber.ToString();
        }
    }
}
