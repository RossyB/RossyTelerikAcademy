using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter number of bit: ");
        int bitNumber = int.Parse(Console.ReadLine());

        int mask = 1 << bitNumber;
        int nAndMask = number & mask;
        int bit = nAndMask >> bitNumber;
        bool isBitOne = bit == 1;
        Console.WriteLine("Bit {0} in the number {1} equals to 1: {2}", bitNumber, number, isBitOne );
    }
}

