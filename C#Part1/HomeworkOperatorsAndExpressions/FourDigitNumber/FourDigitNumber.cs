//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    //Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    //Prints on the console the number in reversed order: dcba (in our example 1102).
    //Puts the last digit in the first position: dabc (in our example 1201).
    //Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        //input
        Console.Write("Enter a four-digit number in format abcd (e.g. 2011): ");
        int number = int.Parse(Console.ReadLine());

        //solution
        int[] numbers = new int[4];

        for (int i = 3; i >= 0; i--)
        {
            numbers[i] = number % 10;
            number = number / 10;
        }

        int sumOfDigit = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sumOfDigit += numbers[i];
        }
       
        string reversedNumber = "";

        for (int i = 3; i >= 0; i--)
        {
            reversedNumber += numbers[i];
        }
      
        string lastDigitToFirst = numbers[numbers.Length - 1].ToString();
        for (int i = 0; i < numbers.Length-1; i++)
        {
            lastDigitToFirst += numbers[i];
        }

        string swapSecondAndThirdDigit = numbers[0].ToString() + numbers[2] + numbers[1] + numbers[3];

        //print
        Console.WriteLine("Sum of the digits is: {0}", sumOfDigit);
        Console.WriteLine("Reversed number is: {0}", reversedNumber);
        Console.WriteLine("Last digit to first in number is: {0}", lastDigitToFirst);
        Console.WriteLine("Exchanged second and third digit in number is: {0}", swapSecondAndThirdDigit);
    }
}
