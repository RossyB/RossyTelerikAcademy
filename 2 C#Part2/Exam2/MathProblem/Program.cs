using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static int ChangeChar(char digit)
    {
        return digit - 'a';  
    }

    static BigInteger Power(int digit, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= digit;
        }
        return result;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        BigInteger[] convertNumbers = new BigInteger[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            string currentWord = input[i];
            int power = 0;
            BigInteger numberInDigit = 0;

            for (int j = currentWord.Length - 1; j >=0; j--)
            {
                
                BigInteger currentNumber = currentWord[j] - 'a';

                numberInDigit += currentNumber * Power(19, power);
                power++;
            }
            convertNumbers[i] = numberInDigit;
        }

        BigInteger resultInDigit = 0;

        for (int i = 0; i < convertNumbers.Length; i++)
        {
            resultInDigit += convertNumbers[i];
        }

        int numeralSystem = 19;

        StringBuilder resultInNineTeen = new StringBuilder();

        BigInteger number = resultInDigit;
        char[] nineteen = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's' };

        while (number > 0)
        {
            int digitInDecimal = (int)(number % (int)numeralSystem);

            resultInNineTeen.Insert(0, nineteen[digitInDecimal]);
            number = number / (int)numeralSystem;
        }
        Console.WriteLine("{0} = {1} ", resultInNineTeen, resultInDigit);
    }
}
