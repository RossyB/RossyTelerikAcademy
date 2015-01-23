using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        bool areEqual = Math.Abs(firstNumber - secondNumber) < 0.000001;

        Console.WriteLine("Yhe numbers are equal: {0}", areEqual);
    }
}

