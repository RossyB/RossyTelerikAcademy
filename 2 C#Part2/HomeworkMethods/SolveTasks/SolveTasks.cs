using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SolveTasks
{
    static void Main()
    {
        Present();
        Menu();
    }

    static void InputNumberForReverse()
    {
        Console.Write("Enter number to reverse: ");
        string number = Console.ReadLine();
        if (number.StartsWith("-"))
        {
            Console.WriteLine("The number should be non-negative! Please try again!");
            InputNumberForReverse();
        }
        number.Trim('.');
        StringBuilder reversed = new StringBuilder();
        Reverse(number, reversed);
        Continue();
    }

    static void Reverse(string number, StringBuilder reversed)
    {
        foreach (char digit in number)
        {
            reversed.Insert(0, digit);
        }
        Console.WriteLine(reversed.ToString());
    }

    static void Continue()
    {
        Console.Write("Do you want to continue? Y/N: ");
        string choice = Console.ReadLine();
        if (choice == "Y" || choice == "y") Menu();
        else Environment.Exit(0);
    }

    static void InputArrayForAverage()
    {
        Console.Write("How many numbers would you like to input?: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid number of numbers! Try again!");
            InputArrayForAverage();
        }
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter " + (i + 1));
            switch (i + 1)
            {
                case 1:
                    Console.Write("st ");
                    break;
                case 2:
                    Console.Write("nd ");
                    break;
                case 3:
                    Console.Write("rd ");
                    break;
                default:
                    Console.Write("th ");
                    break;
            }
            Console.Write("number: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        CalculateAverage(arr);
        Continue();
    }

    static void CalculateAverage(params int[] numbers)
    {
        int count = 0;
        decimal sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
            count++;
        }
        decimal result = (decimal)(sum / count);
        Console.WriteLine("Average is: " + result);
    }

    static void InputEquation()
    {
        Console.WriteLine("Equation is in format a*x+b=0");
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("This is not a linear equation! Please try again!");
            InputEquation();
        }
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The equation looks like that:");
        if (b > 0) Console.WriteLine(a + "*x + " + b + " = 0");
        else if (b == 0) Console.WriteLine(a + "*x = 0");
        else Console.WriteLine(a + "*x" + b + " = 0");
        SolveEquation(a, b);
        Continue();
    }

    static void SolveEquation(int a, int b)
    {
        decimal x = (-b) / a;
        Console.WriteLine("x equals to " + x);
    }

    static void Present()
    {
        Console.WriteLine("Hello, User!");
    }
    static void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("For reverse the digits of a number, type 1");
        Console.WriteLine("For calculate an average of some numbers, type 2");
        Console.WriteLine("For solving a simple linear equation, choose 3");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1) InputNumberForReverse();
        if (choice == 2) InputArrayForAverage();
        if (choice == 3) InputEquation();
        else
        {
            Console.WriteLine("Sorry, you entered an invalid parameter.");
            Console.WriteLine("Please try again!");
            Menu();
        }
    }
}
