namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Discipline : IComment
    {
        public Discipline(string name, int numberOfLectures, int numbersOfExercises)
        { 
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumbersOfExercises = numbersOfExercises;
        }

        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumbersOfExercises { get; set; }

        public List<string> Comments { get; set; }
          
        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}
