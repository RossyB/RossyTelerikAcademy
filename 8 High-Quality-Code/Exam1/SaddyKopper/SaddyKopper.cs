using System;
using System.Numerics;

public class SaddyKopper
{
    public static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        BigInteger result = 1;

        int counter = 0;

        while (number > 1)
        {
            counter = 1;
            number = number / 10;

            string currentnumber = number.ToString();

            BigInteger currentEvenSum = 0;

            for (int i = 0; i < currentnumber.Length; i++)
            {
                if (i % 2 == 0)
                {
                    currentEvenSum += currentnumber[i] - '0';
                }
            }

            if (currentEvenSum != 0)
            {
                result *= currentEvenSum;
            }
        }

        while (result > 10)
        {
            counter++;
            
            if (counter > 10)
            {
                break;
            }

            number = result;
            result = 1;

            while (number > 1)
            {
                number = number / 10;

                string currentnumber = number.ToString();

                BigInteger currentEvenSum = 0;

                for (int i = 0; i < currentnumber.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        currentEvenSum += currentnumber[i] - '0';
                    }
                }

                if (currentEvenSum != 0)
                {
                    result *= currentEvenSum;
                }
            }
        }

        if (counter < 10)
        {
            Console.WriteLine(counter);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}
