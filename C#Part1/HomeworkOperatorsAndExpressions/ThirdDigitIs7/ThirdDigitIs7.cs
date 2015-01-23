//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        //input
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        //solution
        int thirdDigit = (number / 100) % 10;
        string isSeven;

        if (thirdDigit == 7)
        {
            isSeven = "";
        }
        else
        {
            isSeven = "not ";
        }
        
        //print 
        Console.WriteLine("The third digit of the number is {0}seven.", isSeven);
    }
}
