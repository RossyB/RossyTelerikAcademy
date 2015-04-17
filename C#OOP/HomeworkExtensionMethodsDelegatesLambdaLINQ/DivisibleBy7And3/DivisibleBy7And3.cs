namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DivisibleBy7And3
    {
        public static void Main()
        {
            int[] intNumbers = new int[99];
            for (int i = 0; i < intNumbers.Length; i++)
            {
                intNumbers[i] = i + 1;
            }

            // find with lambda
            var divideNumbers = intNumbers.Where(num => num % 21 == 0);

            Console.WriteLine(string.Join(", ", divideNumbers));
            Console.WriteLine();

            // find with LINQ
            divideNumbers =
                from num in intNumbers
                where num % 21 == 0
                select num;

            Console.WriteLine(string.Join(", ", divideNumbers));
            Console.WriteLine();
        }
    }
}
