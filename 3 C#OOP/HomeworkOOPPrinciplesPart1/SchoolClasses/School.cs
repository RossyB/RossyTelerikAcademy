namespace SchoolClasses
{
    using System.Collections.Generic;

    public class School
    {
        public School(string name)
        {
            this.Name = name;
            this.Classes = new List<SchoolClass>();
        }

        public string Name { get; private set; }

        public List<SchoolClass> Classes { get; private set; }
    }
}
