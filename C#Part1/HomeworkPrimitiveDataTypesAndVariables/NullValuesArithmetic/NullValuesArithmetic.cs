using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? numberOne = null;
        long? numberTwo = null;

        Console.WriteLine("|{0}|", numberOne);
        Console.WriteLine("|{0}|", numberTwo);

        numberOne = 103456;
        numberTwo = 54324567898;

        Console.WriteLine("|{0}|", numberOne);
        Console.WriteLine("|{0}|", numberTwo);

        numberOne = null;
        numberTwo = 0;

        Console.WriteLine("|{0}|", numberOne);
        Console.WriteLine("|{0}|", numberTwo);
    }
}
