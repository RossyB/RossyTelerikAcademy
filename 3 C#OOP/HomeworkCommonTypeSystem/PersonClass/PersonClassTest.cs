using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class PersonClassTest
    {
        static void Main()
        {
            Person firstPerson = new Person("Ivan");
            Person secondPerson = new Person("Petar", 30);
            Person thirdPerson = new Person("Nikolai", 23);
            Person fourthPerson = new Person("Petia");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
            Console.WriteLine(thirdPerson);
            Console.WriteLine(fourthPerson);
        }
    }
}
