namespace FirstBeforeLastName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class FirstBeforeLastName
    {
        static void Main(string[] args)
        {

            var students = new[]
        {    
            new {FirstName = "Ivan", LastName = "Ivanov"},
            new {FirstName = "Petar", LastName = "Shterev"},
            new {FirstName = "Georgi", LastName = "Mihov"},
            new {FirstName = "Angel", LastName = "Mihailov"},
            new {FirstName = "Ralica", LastName = "Ivanova"},
            new {FirstName = "Petia", LastName = "Dimitrova"},
            new {FirstName = "Dimitar", LastName = "Petrov"},
        };

            var sortedStudents = 
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select (student.FirstName + " " + student.LastName);

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
