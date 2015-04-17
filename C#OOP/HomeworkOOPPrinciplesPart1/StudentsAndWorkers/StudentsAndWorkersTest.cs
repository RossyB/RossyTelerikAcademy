namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkersTest
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Ivan", "Ivanov", 4));
            students.Add(new Student("Ivan", "Petrov", 1));
            students.Add(new Student("Petar", "Ivanov", 1));
            students.Add(new Student("Petar", "Petrov", 2));
            students.Add(new Student("Yana", "Ivanova", 4));
            students.Add(new Student("Rossi", "Todorova", 3));
            students.Add(new Student("Stoyan", "Stoyanov", 2));
            students.Add(new Student("Nikolay", "Dimitrov", 3));
            students.Add(new Student("Petia", "Georgieva", 5));
            students.Add(new Student("Georgi", "Mihov", 3));

            var sortedStudentsByGrade =
                students.OrderBy(student => student.Grade).ToList();

            Console.WriteLine("-------Students by grade-------");
            foreach (var student in sortedStudentsByGrade)
            {
                Console.WriteLine("{0} - grade: {1}", student, student.Grade);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Ivan", "Ivanov", 200, 8));
            workers.Add(new Worker("Teodor", "Todorov", 300, 8));
            workers.Add(new Worker("Vasil", "Vasilev", 400, 6));
            workers.Add(new Worker("Mitko", "Todorov", 1300, 8));
            workers.Add(new Worker("Atanas", "Atanasov", 300, 8));
            workers.Add(new Worker("Stancho", "Stanchev", 3300, 8));
            workers.Add(new Worker("Vania", "Petrova", 200, 4));
            workers.Add(new Worker("Sonia", "Soianova",300 , 8));
            workers.Add(new Worker("Nikolina", "Dimitrova", 400, 8));
            workers.Add(new Worker("Petko", "Mihov", 1200, 8));

            var sortedWorkersBySalary =
                workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            Console.WriteLine("--------Workers by salary--------");
            foreach (var worker in sortedWorkersBySalary)
            {
                Console.WriteLine("{0}, money per hour - {1:F2} lv.", worker, (decimal)worker.MoneyPerHour());
            }
            Console.WriteLine();

            var merderedList = workers.Concat<Human>(students)
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName).ToList();

            foreach (var human in merderedList)
            {
                Console.WriteLine("{0} - {1}", human, human.GetType().Name);
            }
        }
    }
}
