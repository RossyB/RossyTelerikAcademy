namespace StudentClass
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, string middleName, string lastName, int ssn, string permanentAddress,
            string mobilePhone, string email, int course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }


        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (this.Ssn != student.Ssn)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2} \nSSN: {3} \nSpeciality: {4} \nFaculty: {5} \nUniversity: {6}",
                this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.Specialty, this.University, this.Faculty);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode() ^ Ssn.GetHashCode();
        }

        public Student Clone()
        {
            Student newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.PermanentAddress,
                this.MobilePhone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);
            return newStudent;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Equals(firstStudent, secondStudent);
        }

        public int CompareTo(Student student)
        {
            if (FirstName.CompareTo(student.FirstName) != 0)
                return FirstName.CompareTo(student.FirstName);
            else if (MiddleName.CompareTo(student.MiddleName) != 0)
                return MiddleName.CompareTo(student.MiddleName);
            else if (LastName.CompareTo(student.LastName) != 0)
                return LastName.CompareTo(student.LastName);
            else
            {
                return Ssn.CompareTo(student.Ssn);
            }
        }
    }
}
