namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customers customer, decimal balance, decimal interstRate, int depositPeriod)
            :base(customer, balance, interstRate)
        {
            this.DepositPeriod = depositPeriod;
        }

        public int DepositPeriod { get; private set; }

        public override void Deposit(decimal money)
        {
            this.Balance += money; ;
        }

        public override void Withdraw(decimal money)
        {
            if (this.Balance > money)
            {
                this.Balance -= money;
            }
            else
            {
                throw new ArgumentException("You don't have enought money!");
            }
        }

        public override decimal CalculateInterest()
        {
            if (this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return this.DepositPeriod * this.InterestRate;
            }
        }

    }
}
