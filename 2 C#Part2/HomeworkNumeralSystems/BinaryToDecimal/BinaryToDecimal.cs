//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binaryNumber = Console.ReadLine();
        int decimalNumber = ConvertBinaryToDecimal(binaryNumber);

        Console.WriteLine(decimalNumber);

    }

    static int ConvertBinaryToDecimal(string binNumber) 
    {
        int result = 0;
        int power = binNumber.Length - 1;

        for (int i = 0; i < binNumber.Length; i++)
        {
            result = result + int.Parse(binNumber[i].ToString()) * (int)(Math.Pow(2, power));
            power--;
        }

        return result;
    }
}
