namespace AgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string result = String.Format("Student: {0} {1}, age: {2}", this.FirstName, this.LastName, this.Age);
            return result.ToString();
        }
    }
}
