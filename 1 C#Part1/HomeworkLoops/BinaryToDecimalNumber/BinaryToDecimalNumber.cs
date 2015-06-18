//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string input = Console.ReadLine();

        long result = 0;
        int power = 1;

        for (int i = input.Length - 1; i >=0 ; i--)
        {
            int sign = input[i] - 48;
            if (sign == 1)
            {
                result += sign * power;
            }
            power *= 2;
        }
        Console.WriteLine(result);
    }
}
