using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStudents
{
    class OrderStudents
    {
        static void Main()
        {
            Student[] students = 
            {
                new Student("Ivan", "Ivanov"),
                new Student("Ivan", "Petrov"),
                new Student("Stoian", "Petrov"),
                new Student("Petar", "Stoianov"),
                new Student("Petia", "Dimitrova"),
                new Student("Vania", "Ivanova"),
                new Student("Tania", "Georgieva"),
                new Student("Georgi", "Mihov"),
                new Student("Petar", "Ivanov"),
                new Student("Angel", "Mihov")
            };

            //sorting with lambda expressions 
            var orderedStudents =
                students.OrderByDescending(student => student.FirstName).
                ThenByDescending(student => student.LastName);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //sorting with LINQ
            orderedStudents =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
