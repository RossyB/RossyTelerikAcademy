namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StudentGroups
    {
        static void Main()
        {
            var students = new List<Student>();

            students.Add(new Student("Ivan", "Petrov", "00114", "088 9876543", "ivan@abv.bg", new List<int>{ 6, 4, 6, 2 }, 2));
            students.Add(new Student("Petar", "Ivanov", "00206", "02 3456789", "petar@gmail.com", new List<int> { 6, 6, 5, 6 }, 2));
            students.Add(new Student("Georgi", "Georgiev", "00306", "+3592 4879466", "georgi@abv.bg", new List<int> { 4, 2, 2, 5 }, 1));
            students.Add(new Student("Vania", "Dimitrova", "00113", "088 4786946", "vania@gmail.com", new List<int> { 6, 5, 4, 5 }, 1));

            Console.WriteLine("All students: ");
            Console.WriteLine(new string('-', 25));
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            //select students in group 2
            //implement with LINQ
            var studentsFromGroup2 =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            Console.WriteLine("Students from group 2 select with LINQ: ");
            Console.WriteLine(new string('-', 25));
            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine(student);
            }

            //select students in group 2
            //implement with Lambda expresoions
            studentsFromGroup2 = students.Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName);

            Console.WriteLine("Students from group 2 select with Lambda expresions: ");
            Console.WriteLine(new string('-', 25));
            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine(student);
            }

            //extract all students with email in abv.bg using LINQ
            var studentsWithEmailsInAbv =
            from student in students
            where student.Email.Contains("@abv.bg")
            select student;

            Console.WriteLine("Students with e-mail in abv.bg with LINQ: ");
            Console.WriteLine(new string('-', 25));
            foreach (var student in studentsWithEmailsInAbv)
            {
                Console.WriteLine(student);
            }

            //extract all students with telefin in Sofia using LINQ
            var studentsWithPhonesInSofia =
            from student in students
            where student.Tel.StartsWith("02") || student.Tel.StartsWith("+3592")
            select student;

            Console.WriteLine("Students with telefon in Sofia with LINQ: ");
            Console.WriteLine(new string('-', 25));
            foreach (var student in studentsWithPhonesInSofia)
            {
                Console.WriteLine(student);
            }

            //Select all students that have at least one mark Excellent (6)
            // into a new anonymous class that has properties – FullName and Marks.

            var studentsWithExcellentMark =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    MarksList = student.Marks
                };

            Console.WriteLine("Students that have at least one excellent mark: ");
            Console.WriteLine(new string('-', 25));
            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }

            // extract the students with exactly two marks "2".
            var studentsWithTwoTwos = students.Where(x => x.Marks.FindAll(y => y == 2).Count == 2).
            Select(x => new
            {
                FullName = x.FirstName + " " + x.LastName,
                MarksList = x.Marks
            });
            Console.WriteLine("Students that have exactly two poor marks: ");
            Console.WriteLine(new string('-', 25));
            foreach (var student in studentsWithTwoTwos)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }
        }
    }
}
