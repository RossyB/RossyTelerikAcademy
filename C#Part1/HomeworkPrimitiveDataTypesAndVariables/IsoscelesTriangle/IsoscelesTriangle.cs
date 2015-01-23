//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//    ©
//   © ©
//  ©   ©
// © © © ©


using System;
using System.Text;


class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char copyRight = '\u00a9';

        Console.WriteLine("   {0}  ", copyRight);
        Console.WriteLine("  {0} {0} ", copyRight);
        Console.WriteLine(" {0}   {0}", copyRight);
        Console.WriteLine("{0} {0} {0} {0}", copyRight);
    }
}
