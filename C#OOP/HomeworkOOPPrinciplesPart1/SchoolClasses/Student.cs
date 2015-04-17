namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Student : Person, IComment
    {
        public Student(string name, string uniqueClassNumber): base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string UniqueClassNumber { get; private set; }

        public List<string> Comments{ get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
