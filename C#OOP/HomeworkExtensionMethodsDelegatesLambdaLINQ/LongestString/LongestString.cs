namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class LongestString
    {
        static void Main()
        {
            string[] someStrings =
                    {
                    "Lorem",
                    "ipsum",
                    "dolor",
                    "sit",
                    "amet",
                    "consectetur",
                    "adipiscing",
                    "elit"
                    };

            var sorted =
            from strings in someStrings
            orderby strings.Length descending
            select strings;

            string longest = sorted.FirstOrDefault();

            Console.WriteLine("The longest string is {0}", longest);

        }
    }
}
