namespace BankAccounts
{
    using System;
    using System.Collections.Generic;

    class BankAccountsTest
    {
        static void Main()
        {
            List<Customers> customersList = new List<Customers>();

            customersList.Add(new Individuals("Ivan Ivanov", 20));
            customersList.Add(new Individuals("Tania Kirova", 43));
            customersList.Add(new Companies("Petko Yanev OOD", 102345678));
            customersList.Add(new Companies("Fantom OOD", 200345678));

            List<Account> accountsList = new List<Account>();

            accountsList.Add(new DepositAccount(customersList[0], 1010, 0.06m, 10));
            accountsList.Add(new DepositAccount(customersList[1], 2000, 0.1m, 10));
            accountsList.Add(new LoanAccount(customersList[2], 1000, 0.06m, 10));
            accountsList.Add(new MortgageAccount(customersList[3], 1000, 0.06m, 10));

            foreach (var account in accountsList)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("{0} have balance: {1} and interest rate {2}", account.Customer.Name, account.Balance, account.CalculateInterest());
                account.Deposit(2000);

                if (account is DepositAccount)
                {
                    Console.WriteLine("{0} have balance: {1} and interest rate {2}", account.Customer.Name, account.Balance, account.CalculateInterest());
                    account.Withdraw(100);
                    Console.WriteLine("I 've just drow out some money");
                    Console.WriteLine("{0} have balance: {1} and interest rate {2}", account.Customer.Name, account.Balance, account.CalculateInterest());
                    Console.WriteLine("---------------------------------------------------");
                }
            }

        }
    }
}
