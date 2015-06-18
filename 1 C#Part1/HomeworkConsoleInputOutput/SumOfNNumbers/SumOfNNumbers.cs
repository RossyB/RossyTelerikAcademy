//Write a program that enters a number n and after that enters more n numbers 
//and calculates and prints their sum. Note: You may need to use a for-loop.

using System;
using System.Globalization;
using System.Threading;

class SumOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the number n: ");
        int numberN = int.Parse(Console.ReadLine());
        
        float[] numbers = new float[numberN];
        float sumNumbers = 0;

        for (int i = 0; i < numberN; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = float.Parse(Console.ReadLine());
            sumNumbers += numbers[i];
            
        }
        Console.WriteLine("The sun of {0} numbers is: {1}", numberN, sumNumbers);

    }
}
