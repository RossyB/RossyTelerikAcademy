namespace BankAccounts
{
    public abstract class Account
    {
        public Account(Customers customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customers Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public int NumberOfMonts { get; set; }

        public virtual void Deposit(decimal money)
        {
        }

        public virtual void Withdraw(decimal money)
        {
        }

        public virtual decimal CalculateInterest()
        {
            return NumberOfMonts * this.InterestRate;
        }
    }
}
