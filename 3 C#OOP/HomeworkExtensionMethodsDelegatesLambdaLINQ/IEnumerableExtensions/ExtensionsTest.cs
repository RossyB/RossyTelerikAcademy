namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ExtensionsTest
    {
        public static void Main()
        {
            int[] elements = new int[15];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = i + 1;
            }

            Console.WriteLine("Sum: {0}", elements.Sum<int>());
            Console.WriteLine("Product: {0}", elements.Product<int>());
            Console.WriteLine("Min: {0}", elements.Min<int>());
            Console.WriteLine("Max: {0}", elements.Max<int>());
            Console.WriteLine("Average: {0}", elements.Average<int>());

        }
    }
}
