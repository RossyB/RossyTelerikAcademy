//Write an expression that checks if given integer is odd or even.

using System;

class Program
{
    static void Main()
    {
        //input
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool isOddNumber;

        //solution
        if (number % 2 == 0)
        {
            isOddNumber = false;
        }
        else
        {
            isOddNumber = true;
        }

        //print
        Console.WriteLine("Is the number odd?: {0}", isOddNumber);
    }
}
