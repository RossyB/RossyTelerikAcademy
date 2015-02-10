//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    //If the variable is int or double, the program increases it by one.
    //If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.


using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {

        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        int choise = int.Parse(Console.ReadLine());

        int userValue1;
        double userValue2;
        string userValue3;

        switch (choise)
        {
            case 1:
                Console.Write("Please enter a int value: ");
                userValue1 = int.Parse(Console.ReadLine());
                userValue1++;
                Console.WriteLine(userValue1);
                break;
                
            case 2:
                Console.Write("Please enter a double value: ");
                userValue2 = double.Parse(Console.ReadLine());
                userValue2++;
                Console.WriteLine(userValue2.ToString());
                break;

            case 3:
                Console.Write("Please enter a string: ");
                userValue3 = Console.ReadLine();
                userValue3 = userValue3 + '*';
                Console.WriteLine(userValue3);
                break;

            default:
                Console.WriteLine("Invalid value!");
                break;
        }
    }
}
