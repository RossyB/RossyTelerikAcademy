namespace AnimalHierarchy
{
    public class Frog: Animal, ISound
    {
        public Frog(string name, int age, Gender sex)
            : base(name, age, sex)
        { 
        }

        public override string ProduceSound()
        {
            return string.Format("{0} says Qwak!", this.Name);
        }
    }
}
