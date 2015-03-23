//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Please, enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        if (decimalNumber < 0)
        {
            decimalNumber = (Math.Abs(decimalNumber) - 1);
            List<byte> byteNumber = new List<byte>();
            byte element = 0;
            while (decimalNumber > 0)
            {
                element = (byte)(decimalNumber % 2);
                byteNumber.Add(element);
                decimalNumber = (short)(decimalNumber / 2);
            }

            byteNumber.Reverse();
            List<byte> binaryNumber = new List<byte>();
            int rem = byteNumber.Count;
            int i;
            for (i = 0; i < 16 - rem; i++)
            {
                binaryNumber.Add(0);
            }

            foreach (var member in byteNumber)
            {
                binaryNumber.Add(member);
            }
            foreach (var member in binaryNumber)
            {
                Console.Write(member > 0 ? 0 : 1);
            }
            Console.WriteLine();
        }
        else
        {
            List<byte> byteNumber = new List<byte>();
            byte element = 0;
            while (decimalNumber > 0)
            {
                element = (byte)(decimalNumber % 2);
                byteNumber.Add(element);
                decimalNumber = (short)(decimalNumber / 2);
            }

            byteNumber.Reverse();
            foreach (var member in byteNumber)
            {
                Console.Write(member);
            }
            Console.WriteLine();
        }
    }
}
