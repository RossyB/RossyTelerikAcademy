namespace PrintStatisticsTask
{
    using System;

    /// <summary>
    /// Class for statistics
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// Main method for testing.
        /// </summary>
        public static void Main()
        {
            double[] numbers = new double[8] { 4.4, 67.03, 9, 3.4, 98.9, 34, 23.7, 67 };

            PrintStatistics(numbers);
        }

        /// <summary>
        /// static method for printing statistics.
        /// </summary>
        /// <param name="numbers">Array for printing statistics</param>
        private static void PrintStatistics(double[] numbers)
        {
            double maxNumber = double.MinValue;
            double minNumber = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }

                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }

                sum += numbers[i];
            }

            double averageNumber = sum / numbers.Length;

            PrintNumber(maxNumber, "Largest");
            PrintNumber(minNumber, "Smallest");
            PrintNumber(averageNumber, "Average");
        }

        /// <summary>
        /// Static method for printing number and name.
        /// </summary>
        /// <param name="number">number for print.</param>
        /// <param name="name">Name for print.</param>
        private static void PrintNumber(double number, string name)
        {
            Console.WriteLine(name + " number in array is: " + number);
        }
    }
}
