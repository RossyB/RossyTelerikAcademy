namespace BankAccounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customers customer, decimal balance, decimal interestRate, int mortgagePeriod)
            : base(customer, balance, interestRate)
        {
            this.MortgagePeriod = mortgagePeriod;
        }

        public int MortgagePeriod { get; set; }

        public override void Deposit(decimal money)
        {
            this.Balance = money;
        }

        public override decimal CalculateInterest()
        {
            if (MortgagePeriod < 12 && Customer is Companies)
            {
                return this.InterestRate / 2 * this.MortgagePeriod;
            }
            else if (this.MortgagePeriod <= 6 && Customer is Individuals)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * this.MortgagePeriod;
            }
        }
    }
}
