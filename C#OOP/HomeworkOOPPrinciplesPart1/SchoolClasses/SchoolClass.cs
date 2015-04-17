namespace SchoolClasses
{
    using System.Collections.Generic;

    public class SchoolClass: IComment
    {
        public SchoolClass(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public string Name { get; private set; }

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<string> Comments {get; set;}

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
