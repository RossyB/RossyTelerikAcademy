namespace StudentClass
{
    using System;

    class StudentClassTest
    {
        static void Main()
        {
            Student firstStudent = new Student("Ivan", "Petrov", "Ivanov", 456789,
                "Burgas, ul. Ferdinandova", "088456789", "ivan@abv.bg", 3,
                Specialty.InformationTechnology, University.TechnicalUniversity, Faculty.InformationFac);
            Student secondStudent = new Student("Petar", "Petrov", "Ivanov", 123456,
                "Burgas, ul. Carigradska", "082342356", "petar@abv.bg", 4,
                Specialty.Mathematics, University.SofiaUniversity, Faculty.MathematicsFac);
            Student thirdStudent = new Student("Wania", "Petrova", "Dimova", 359456,
                "Burgas, ul. Hristo Botev", "082342356", "vania@abv.bg", 1,
                Specialty.SoftwareEngineering, University.TechnicalUniversity, Faculty.SoftwareFac);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(secondStudent.ToString());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(thirdStudent.ToString());
            Console.WriteLine("-------------------------------------");

            Console.WriteLine(firstStudent == secondStudent);
            Console.WriteLine(firstStudent != thirdStudent);

            Console.WriteLine(firstStudent.Equals(secondStudent));
            Console.WriteLine(thirdStudent.Equals(thirdStudent));

            Student firstStudentCopy = firstStudent.Clone();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(firstStudentCopy);
            firstStudentCopy.Specialty = Specialty.SoftwareEngineering;
            firstStudentCopy.University = University.TechnicalUniversity;
            firstStudentCopy.Faculty = Faculty.SoftwareFac;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(firstStudent);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(firstStudentCopy);

        }
    }
}
