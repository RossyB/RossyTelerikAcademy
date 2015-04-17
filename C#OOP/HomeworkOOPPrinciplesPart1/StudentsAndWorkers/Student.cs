namespace StudentsAndWorkers
{
    using System.Text;

    public class Student : Human
    {
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1}", this.FirstName, this.LastName, this.Grade);
            return result.ToString();
        }
    }
}
