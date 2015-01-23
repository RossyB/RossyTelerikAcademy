using System;

class ExtractBitFromInteger
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
        Console.WriteLine("Bit {0} in the number {1} is: {2}", bitNumber, number, bit);
    }
}

