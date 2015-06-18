namespace BankAccounts
{
    public class Companies : Customers
    {
        public Companies(string name, int bulstat)
            : base(name)
        {
            this.Bulstat = bulstat;
        }

        public int Bulstat { get; private set; }
    }
}
