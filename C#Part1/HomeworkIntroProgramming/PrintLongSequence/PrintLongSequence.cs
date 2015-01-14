using System;

class PrintLongSequence
{
    static void Main()
    {
        int n = 1000;

        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i + ", ");
            }

        }

    }
}
