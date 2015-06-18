//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());

        long reminder;
        string result = string.Empty;

        while (decimalNumber > 0)
        {
            reminder = decimalNumber % 2;
            decimalNumber /= 2;
            result = reminder.ToString() + result;
        }
        Console.WriteLine("Binary number: {0}", result);
    }
}
