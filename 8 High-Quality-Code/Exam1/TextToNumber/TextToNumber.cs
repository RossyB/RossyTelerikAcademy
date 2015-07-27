using System;

public class TextToNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string text = Console.ReadLine().ToUpper();

        int result = 0;

        foreach (char symbol in text)
        {
            if (symbol >= '0' && symbol <= '9')
            {
                result *= symbol - '0';
            }
            else if (symbol >= 'A' && symbol <= 'Z')
            {
                result += symbol - 'A';
            }
            else if (symbol == '@')
            {
                Console.WriteLine(result);
            }
            else
            {
                result = result % number;
            }
        }
    }
}
