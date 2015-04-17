namespace BankAccounts
{
    class Individuals : Customers
    {

        public Individuals(string name, int age)
            : base(name)
        {
            this.Age = age;
        }

        public int Age { get; private set; }
    }
}
