//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NumberAsArray
{
    private static void SumOfTwoNumbers(byte[] first, byte[] second)
    {
        byte[] result = new byte[Math.Max(first.Length, second.Length) + 1];
        Array.Reverse(first);
        Array.Reverse(second);
        byte addition = 0;
        byte temp = 0;
        for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
        {
            temp = (byte)(first[i] + second[i] + addition);
            if (temp >= 10)
            {
                addition = 1;
                result[i] = (byte)(temp % 10);
            }
            else
            {
                addition = 0;
                result[i] = temp;
            }
            if (i + 1 == Math.Min(first.Length, second.Length))
            {
                for (int j = i + 1; j < Math.Max(first.Length, second.Length); j++)
                {
                    if (first.Length > second.Length)
                    {
                        temp = (byte)(first[j] + addition);
                        if (temp >= 10)
                        {
                            addition = 1;
                            result[j] = (byte)(temp % 10);
                        }
                        else
                        {
                            addition = 0;
                            result[j] = temp;
                        }
                    }
                    else
                    {
                        temp = (byte)(second[j] + addition);
                        if (temp >= 10)
                        {
                            addition = 1;
                            result[j] = (byte)(temp % 10);
                        }
                        else
                        {
                            addition = 0;
                            result[j] = temp;
                        }
                    }
                    if (j + 1 == Math.Max(first.Length, second.Length) && addition == 1)
                    {
                        result[j + 1] = addition;
                    }
                }
            }
        }
        Array.Reverse(result);
        for (int i = 0; i < result.Length; i++)
        {
            if (i == 0 && i == result[i]) continue;
            else Console.Write(result[i]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        byte[] first = { 1, 7, 4, 2, 7, 8, 9, 0, 1, 2, 3, 4, 6, 1, 2 };
        byte[] second = { 5, 7, 8, 9, 1, 9, 2, 5 };

        SumOfTwoNumbers(first, second);

        //test with the mere numbers, if they are equal to the array -> it's fine
        Console.WriteLine(174278901234612 + 57891925);
    }
}
