namespace RefactorLoop
{
    using System;

    /// <summary>
    /// Class for refactoring
    /// </summary>
    public class RefactorLoop
    {
        /// <summary>
        /// Main method
        /// </summary>
        public static void Main()
        {
            const int ExpectedValue = 666;
            const int NumberOfElements = 100;

            int[] array = new int[NumberOfElements];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 1000);
            }

            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);

                    if (array[i] == ExpectedValue)
                    {
                        isFound = true;
                    }
                }
            }

            // More code here
            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
