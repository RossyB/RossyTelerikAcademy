//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
using System.Globalization;
using System.Threading;

class PrintCompanyInformation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter the Comnpany Information");
        Console.WriteLine(new string('-', 40));
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Web site: ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLasttName = Console.ReadLine();
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhone= Console.ReadLine();

        Console.WriteLine(new string('-', 40));
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel.: {0}", companyPhone);
        if (companyFax.Length < 10)
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", companyFax);
        }
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel.: {3})", managerFirstName, managerLasttName, managerAge, managerPhone);
        Console.WriteLine(new string('-', 40));
    }
}

