namespace GameMine
{
    using System;

    public class PlayerScores
    {
        string name;
        int scores;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Scores
        {
            get { return scores; }
            set { scores = value; }
        }

        public PlayerScores(string name, int scores)
        {
            this.name = name;
            this.scores = scores;
        }
    }
}
