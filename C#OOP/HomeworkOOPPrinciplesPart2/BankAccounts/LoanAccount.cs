namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customers customer, decimal balance, decimal interestRate, int loanPeriod)
            : base(customer, balance, interestRate)
        {
            this.LoanPeriod = loanPeriod;
        }

        public int LoanPeriod { get; private set; }

        public override void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalculateInterest()
        {
            if (this.LoanPeriod <= 3 && Customer is Individuals)
            {
                return 0;
            }
            else if (this.LoanPeriod <= 2 && Customer is Companies)
            {
                return 0;
            }
            else
            {
                return this.LoanPeriod * this.InterestRate;
            }
        }
    }
}
