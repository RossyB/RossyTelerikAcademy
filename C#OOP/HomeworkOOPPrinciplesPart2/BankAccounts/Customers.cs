namespace BankAccounts
{
    public abstract class Customers
    {
        public Customers(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
