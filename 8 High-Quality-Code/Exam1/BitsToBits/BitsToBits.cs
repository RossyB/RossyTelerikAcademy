using System;

public class BitsToBits
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        string[] numbers = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            long currentNumber = long.Parse(Console.ReadLine());
            numbers[i] = Convert.ToString(currentNumber, 2).PadLeft(30, '0');
        }

        string concatNumbers = string.Empty;

        for (int i = 0; i < numbers.Length; i++)
        {
            concatNumbers += numbers[i];
        }

        int maxSequenceZero = 0;
        int maxSequenceOne = 0;

        int counterZero = 1;
        int counterOne = 1;

        for (int i = 0; i < concatNumbers.Length; i++)
        {
            if (concatNumbers[i] == '0' && i != concatNumbers.Length - 1)
            {
                if (concatNumbers[i + 1] == '0')
                {
                    counterZero++;
                }
            }
            else
            {
                counterZero = 1;
            }

            if (maxSequenceZero < counterZero)
            {
                maxSequenceZero = counterZero;
            }
        }

        for (int i = 0; i < concatNumbers.Length; i++)
        {
            if (concatNumbers[i] == '1' && i != concatNumbers.Length - 1)
            {
                if (concatNumbers[i + 1] == '1')
                {
                    counterOne++;
                }
            }
            else
            {
                counterOne = 1;
            }

            if (maxSequenceOne < counterOne)
            {
                maxSequenceOne = counterOne;
            }
        }

        Console.WriteLine(maxSequenceZero);
        Console.WriteLine(maxSequenceOne);
    }
}
