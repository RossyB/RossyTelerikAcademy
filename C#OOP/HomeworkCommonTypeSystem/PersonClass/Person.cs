using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            return string.Format("Person: {0} whith age: {1}", this.Name, this.Age == null ? "not specified" : Age.ToString());
        }
    }
}
