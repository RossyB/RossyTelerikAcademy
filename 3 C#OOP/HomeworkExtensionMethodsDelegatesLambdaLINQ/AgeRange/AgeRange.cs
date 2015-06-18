namespace AgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AgeRange
    {
        public static void Main()
        {
            Student[] students = 
            {
                new Student("Ivan", "Ivanov", 23),
                new Student("Stoian", "Petrov", 24),
                new Student("Petar", "Stoianov", 20),
                new Student("Petia", "Dimitrova", 18),
                new Student("Vania", "Ivanova", 30),
                new Student("Tania", "Georgieva", 19),
                new Student("Georgi", "Mihov", 17),
            };

            var ageInterval =
                from student in students
                where (student.Age >= 18) && (student.Age <= 24)
                select student;

            foreach (Student student in ageInterval)
            {
                Console.WriteLine(student);
            }
        }
    }
}
