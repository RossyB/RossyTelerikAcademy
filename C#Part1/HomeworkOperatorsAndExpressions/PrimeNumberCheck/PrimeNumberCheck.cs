//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
        }
        for (int i = 2; i <= (int)(Math.Sqrt(number)); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("The number is prime");
        }
        else
        {
            Console.WriteLine("The number is not prime");
        }
       
    }
}
