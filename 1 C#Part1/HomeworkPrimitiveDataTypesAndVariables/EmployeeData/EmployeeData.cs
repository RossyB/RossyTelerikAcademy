//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 25;
        char gender = 'm';
        long personalIDNumber = 8306112507;
        long employeeNumber = 27569999;

        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        if (gender == 'm')
        {
            Console.WriteLine("Gender: Male");
        }
        else
        {
            Console.WriteLine("Gender: Female");
        }
        Console.WriteLine("Personal ID number: {0}", personalIDNumber);
        Console.WriteLine("Unique employee number: {0}", employeeNumber);




    }
}
