namespace SchoolClasses
{
    using System.Collections.Generic;

    public interface IComment
    {
        List<string> Comments { get; set; }
        void AddComment(string comment);
    }
}
