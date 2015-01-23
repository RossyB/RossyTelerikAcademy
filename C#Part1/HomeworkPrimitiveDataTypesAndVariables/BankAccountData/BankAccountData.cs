//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
//IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string LastName = "Ivanov";

        decimal balance = 122567.67m;
        string bankName = "Burkan Bank";
        string iban = "BG45ABCF34551504002630";

        string firstCard = "123456789";
        string secondCard = "987654321";
        string thirdCard = "123456789";

        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Middle Name: {0}", middleName);
        Console.WriteLine("Last Name: {0}", LastName);
        Console.WriteLine("Balance: {0} lv.", balance);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("First Card number: {0}", firstCard);
        Console.WriteLine("Second Card number: {0}", secondCard);
        Console.WriteLine("Third Card number: {0}", thirdCard);
    }
}
