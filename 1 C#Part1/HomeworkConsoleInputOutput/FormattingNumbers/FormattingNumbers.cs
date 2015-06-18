//Write a program that reads 3 numbers:
//    integer a (0 <= a <= 500)
//    floating-point b
//    floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//    The number a should be printed in hexadecimal, left aligned
//    Then the number a should be printed in binary form, padded with zeroes
//    The number b should be printed with 2 digits after the decimal point, right aligned
//    The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter an integer number: ");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("Enter a ploating-point number: ");
        float numberB = float.Parse(Console.ReadLine());
        Console.Write("Enter a ploating-point number: ");
        float numberC = float.Parse(Console.ReadLine());

        Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", 
            numberA, Convert.ToString(numberA).PadLeft(10, '0'), numberB, numberC);
    }
}
