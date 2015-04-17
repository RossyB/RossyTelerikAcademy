namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic sum = 0;

            foreach (var item in input)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic product = 1;

            foreach (var item in input)
            {
                product *= item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic minValue = input.First();

            foreach (var item in input)
            {
                if (item.CompareTo(minValue) < 0)
                {
                    minValue = item;
                }
            }
            return minValue;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic maxValue = input.First();

            foreach (var item in input)
            {
                if (item.CompareTo(maxValue) > 0)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }

        public static T Average<T>(this IEnumerable<T> input) where T : IComparable
        {
            dynamic sum = 0;
            dynamic counter = 0;

            foreach (var item in input)
            {
                sum += item;
                counter++;
            }
            return sum / counter;

        }
    }
}
