//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        //input
        Console.Write("Ernter integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool isDidided;

        //solution
        if ((number % 5 == 0) && (number % 7 == 0))
        {
            isDidided = true;
        }
        else
        {
            isDidided = false;
        }

        //print
        Console.WriteLine("Divided by 7 and 5?: {0}", isDidided);
    }
}
