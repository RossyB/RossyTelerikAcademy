//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter tree real number");
        Console.Write("number a: ");
        float numberA = float.Parse(Console.ReadLine());
        Console.Write("number b: ");
        float numberB = float.Parse(Console.ReadLine());
        Console.Write("number c: ");
        float numberC = float.Parse(Console.ReadLine());

        int counter = 0;
        bool isZero = false;

        if (numberA == 0 || numberB == 0 || numberC == 0)
        {
            Console.WriteLine("The product of the three real numbers is 0");
            isZero = true;
        }

        if (numberA < 0)
        {
            counter++;
        }
        if (numberB < 0)
        {
            counter++;
        }
        if (numberC < 0)
        {
            counter++;
        }

        if (counter == 2 || (counter == 0 && isZero == false))
        {
            Console.WriteLine("The product of the three real numbers is with +");
        }
        else if (counter == 1 || counter == 3)
	    {
            Console.WriteLine("The product of the three real numbers is with -");
	    }        
    }
}
