namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public Student(string firstName, string lastname, string fN, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name: {0} {1}\n", this.FirstName, this.LastName);
            result.AppendFormat("Faculty number: {0}\n", this.FN);
            result.AppendFormat("Group number: {0}\n", this.GroupNumber);
            result.AppendFormat("Marks: {0}\n", string.Join(", ", Marks));
            result.AppendFormat("Telefon: {0}\n", this.Tel);
            result.AppendFormat("E-mail: {0}\n", this.Email);

            return result.ToString();
        }
    }
}
