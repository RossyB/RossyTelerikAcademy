namespace Methods
{
    using System;

    public class Methods
    {
        /// <summary>
        /// Calculates Area of a triangle using Herone formula.
        /// </summary>
        /// <param name="a">Fist side of triangle.</param>
        /// <param name="b">Second side of triangle.</param>
        /// <param name="c">Fist side of triangle.</param>
        /// <returns>Returns the triangle area.</returns>
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.Error.WriteLine("Sides should be positive.");
                return -1;
            }

            if (a + b < c || b + c < a || c + a < b)
            {
                throw new ArgumentOutOfRangeException("a,b and c don't make triangle.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>
        /// Translate digit on English.
        /// </summary>
        /// <param name="number">Insert digit.</param>
        /// <returns>Return digit as string in english.</returns>
        public static string TranslateDigitInEnglish(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("You must enter a digit in the range [0...9].");
            }
        }

        /// <summary>
        /// Find max number from Array.
        /// </summary>
        /// <param name="elements">Array of int numbers.</param>
        /// <returns>Return max number.</returns>
        public static int FindMaxElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new NullReferenceException("Array must have almost one element.");
            }

            int maxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        /// <summary>
        /// Print to the console decimal number.
        /// </summary>
        /// <param name="number">Insert a number.</param>
        /// <param name="format">Insert string "f"</param>
        public static void PrintNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
        }

        /// <summary>
        /// Print to the console number as percent.
        /// </summary>
        /// <param name="number">Insert a number.</param>
        /// <param name="format">Insert string "%"</param>
        public static void PrintPersent(object number, string format)
        {
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
        }

        /// <summary>
        /// Print to the console aligned number.
        /// </summary>
        /// <param name="number">Insert a number.</param>
        /// <param name="format">Insert string "r"</param>
        public static void PrintAligned(object number, string format)
        {
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        /// <summary>
        /// Calculate the distance between two poins.
        /// </summary>
        /// <param name="x1">X coordinate of first point</param>
        /// <param name="y1">Y coordinate of first point</param>
        /// <param name="x2">X coordinate of second point</param>
        /// <param name="y2">Y coordinate of second point</param>
        /// <returns>return distatnce between points</returns>
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double xDistance = x2 - x1;
            double yDistance = y2 - y1;
            double distance = Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));
            return distance;
        }

        /// <summary>
        /// Check if line is horizontal.
        /// </summary>
        /// <param name="y1">Y coordinate of first point</param>
        /// <param name="y2">Y coordinate of second point</param>
        /// <returns>Return true if line is horizontal.</returns>
        public static bool IsLineHorizontal(double y1, double y2)
        {
            if (y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if line is vertical.
        /// </summary>
        /// <param name="x1">X coordinate of first point</param>
        /// <param name="x2">X coordinate of second point</param>
        /// <returns>Return true if line is vertical.</returns>
        public static bool IsLineVertical(double x1, double x2)
        {
            if (x1 == x2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
