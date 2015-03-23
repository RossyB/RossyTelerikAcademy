//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter base s: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter base d: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Enter the number: ");

        string number = Console.ReadLine();

        int convNumber = 0;
        string endResult = "";

        if (s == 2 || s == 8)
        {
            convNumber = NumberToDecimal(number, s);
        }
        if (s == 10)
        {
            convNumber = int.Parse(number);
        }
        if (s == 16)
        {
            convNumber = HexadecimalToDecimal(number, s);
        }

        Console.WriteLine("The middle convert number is: {0}", convNumber);

        if (d == 2 || d == 8)
        {
            endResult = DecimalToNumber(convNumber, d);
        }
        if (d == 10)
        {
            endResult = convNumber.ToString();
        }

        if (d == 16)
        {
            endResult = DecimalToHexadecimal(convNumber);
        }

        Console.WriteLine("The convert number is: {0}", endResult);

    }

    static int NumberToDecimal(string str, int s)
    {
        int result = 0;
        int power = str.Length - 1;

        for (int i = 0; i < str.Length; i++)
        {
            result = result + int.Parse(str[i].ToString()) * (int)(Math.Pow(s, power));
            power--;
        }
        return result;
    }

    static string DecimalToNumber(int number, int d)
    {
        string bin = "";
        string result = "";

        while (number > 0)
        {
            bin = bin + number % d;
            number = number / d;
        }

        for (int i = bin.Length - 1; i >= 0; i--)
        {
            result = result + bin[i];
        }
        return result;
    }

    static string DecimalToHexadecimal(int num)
    {
        string dec = "";
        string result = "";

        while (num > 0)
        {
            dec = dec + GetChar(num % 16);
            num = num / 16;
        }

        for (int i = dec.Length - 1; i >= 0; i--)
        {
            result = result + dec[i];
        }
        return result;
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

    static int HexadecimalToDecimal(string str, int s)
    {
        str = str.ToUpper();

        int result = 0;
        int power = str.Length - 1;

        for (int i = 0; i < str.Length; i++)
        {
            result = result + GetNumber(str, i) * (int)(Math.Pow(16, power));
            power--;
        }
        return result;
    }

    static int GetNumber(string str, int i)
    {
        if (str[i] >= 'A') return str[i] - 'A' + 10;
        else return str[i] - '0';
    }
}
