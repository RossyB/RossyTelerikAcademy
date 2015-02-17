//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        int[] firstArr = { 2, 6, 67, 18, 15, 9, 18 };
        int[] secondArr = { 2, 6, 67, 18, 15, 9, 18 };

        bool isEqual = true;

        if (firstArr.Length == secondArr.Length)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i] )
                {
                    isEqual = false;
                    break;
                }
            }
        }
        else
	    {
            isEqual = false;
	    }

        if (isEqual == true)
        {
            Console.WriteLine("The arrays is equal");
        }
        else
        {
            Console.WriteLine("The arrays is not equal");
        }
    }
}
