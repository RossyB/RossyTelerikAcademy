//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter tree integer numbers");
        Console.Write("Enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter number c ");
        int c = int.Parse(Console.ReadLine());

        int maxNumber = GetMax(a, b);
        maxNumber = GetMax(maxNumber, c);

        Console.WriteLine("Max number from {0}, {1} and {2} is {3}.", a, b, c, maxNumber);

    }

    static int GetMax(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
        
    }
}
