using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grouped
{
    class Grouped
    {
        static void Main()
        {
            var students = new List<Student>
            {
            new Student("Ivan","Math"),
            new Student("Petar", "Comupter Science"),
            new Student("Stoyan", "Comupter Science"),
            new Student("Angel", "Math"),
            new Student("Yana", "Comupter Science"),
            new Student("Mariyna", "Math")
            };

            var groupedStudents = students.OrderBy(x => x.Group);

            foreach (var student in groupedStudents)
            {
                Console.WriteLine(student.ToString());
            }

        }
    }
}
