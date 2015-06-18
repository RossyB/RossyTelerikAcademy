namespace SubstringForStringBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class SubstringForStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int lenght)
        {
            StringBuilder substring = new StringBuilder();

            if (index + lenght -1 >= input.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }
            string tempString = input.ToString();
            tempString = tempString.Substring(index, lenght);
            substring.Append(tempString);

            return substring;
        }
    }
}
