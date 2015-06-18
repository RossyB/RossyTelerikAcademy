//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstArray = { 'H', 'e', 'l', 'l', 'o', 'P', 'e', 's', 'h', 'o' };
        char[] secondArray = { 'H', 'e', 'l', 'l', 'o', 'I', 'v', 'o' };

        bool isFirstArrEarlier = true;

        int loopArrLenght = 0;

        if (firstArray.Length > secondArray.Length)
        {
            loopArrLenght = secondArray.Length;
        }
        else
        {
            loopArrLenght = firstArray.Length;
        }


        for (int i = 0; i < loopArrLenght; i++)
        {
            if (firstArray[i] <= secondArray[i])
            {
                isFirstArrEarlier = true;
            }
            else
            {
                isFirstArrEarlier = false;
            }
        }

        if (isFirstArrEarlier)
        {
            Console.WriteLine("First array is earlier.");
        }
        else
        {
            Console.WriteLine("Second array is earlier.");
        }
    }
}
