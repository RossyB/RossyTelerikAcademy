namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    class SchoolTest
    {
        static void Main()
        {
            School school = new School("Telerik Academy");

            SchoolClass class1 = new SchoolClass("On-line");

            school.Classes.Add(class1);

            Student student1 = new Student("Ivan Petrov", "12345");
            Student student2 = new Student("Petar Ivanow", "56789");
            Student student3 = new Student("Vania Stoianova", "34567");

            class1.Students.Add(student1);
            class1.Students.Add(student2);
            class1.Students.Add(student3);

            Discipline course1 = new Discipline("C#Part1", 40, 40);
            Discipline course2 = new Discipline("C#Part2", 40, 40);
            Discipline course3 = new Discipline("C#OOP", 40, 40);

            Teacher teacher1 = new Teacher("Stoian Nikolov");
            Teacher teacher2 = new Teacher("Ivaylo Ivanov");

            teacher1.Disciplines.Add(course1);
            teacher1.Disciplines.Add(course2);
            teacher2.Disciplines.Add(course2);
            teacher2.Disciplines.Add(course3);

            foreach (var course in teacher1.Disciplines)
            {
                Console.WriteLine("Lector: {0}", teacher1.Name);
                Console.WriteLine("Name of course: {0}, lectures: {1}, Exercises: {2}", course.Name, course.NumberOfLectures, course.NumbersOfExercises);
            }

            foreach (var course in teacher2.Disciplines)
            {
                Console.WriteLine("Lector: {0}", teacher2.Name);
                Console.WriteLine("Name of course: {0}, lectures: {1}, Exercises: {2} ", course.Name, course.NumberOfLectures, course.NumbersOfExercises);
            }
        }
    }
}
