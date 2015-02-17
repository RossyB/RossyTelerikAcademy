//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SayHello
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Hello(name);

    }

    static void Hello(string name)
    {
        Console.WriteLine("Hello {0}!", name);
    }
}
