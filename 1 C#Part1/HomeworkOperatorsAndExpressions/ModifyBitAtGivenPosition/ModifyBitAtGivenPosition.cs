//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the 
//position p from the binary representation of n while preserving all other bits in n.


using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter number of bit: ");
        int bitNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit value (0 ot 1): ");
        int valueV = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int newValue;
        int bitAtRight;
        if (valueV == 1)
        {
            bitAtRight = 1 << bitNumber;
            newValue = number | bitAtRight;
            Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32, '0'));
            Console.WriteLine("Result = " + newValue);
        }
        else if (valueV == 0)
        {
            bitAtRight = ~(1 << bitNumber);
            newValue = number & bitAtRight;
            Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32, '0'));
            Console.WriteLine("Result = " + newValue);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }


        Console.WriteLine();

    }
}
