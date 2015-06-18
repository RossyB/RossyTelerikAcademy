namespace StudentsAndWorkers
{
    using System.Text;

    public class Worker: Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary { get; private set; }
        public int WorkHoursPerDay { get; private set; }

        public decimal MoneyPerHour()
        {
            return (decimal)WeekSalary / (WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1}", this.FirstName, this.LastName);
            return result.ToString();
        }
    }
}
