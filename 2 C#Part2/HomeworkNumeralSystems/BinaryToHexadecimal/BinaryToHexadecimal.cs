//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binNumber = Console.ReadLine();

        if (binNumber.Length % 4 == 1)
        {
            binNumber = "000" + binNumber;
        }
        else if (binNumber.Length % 4 == 2)
        {
            binNumber = "00" + binNumber;
        }
        else if (binNumber.Length % 4 == 3)
        {
            binNumber = "0" + binNumber;
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < binNumber.Length; i += 4)
        {
            switch (binNumber.Substring(i, 4))
            {
                case "0000": result.Append("0"); break;
                case "0001": result.Append("1"); break;
                case "0010": result.Append("2"); break;
                case "0011": result.Append("3"); break;
                case "0100": result.Append("4"); break;
                case "0101": result.Append("5"); break;
                case "0110": result.Append("6"); break;
                case "0111": result.Append("7"); break;
                case "1000": result.Append("8"); break;
                case "1001": result.Append("9"); break;
                case "1010": result.Append("A"); break;
                case "1011": result.Append("B"); break;
                case "1100": result.Append("C"); break;
                case "1101": result.Append("D"); break;
                case "1110": result.Append("E"); break;
                case "1111": result.Append("F"); break;
            }
        }

        Console.WriteLine("Hexadecimal number is: {0}", result);
    }
}
