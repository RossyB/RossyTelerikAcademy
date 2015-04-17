namespace AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Gender sex)
            : base(name, age, sex)
        { 
        }

        public override string ProduceSound()
        {
            return string.Format("{0} says Bau!", this.Name);
        }
    }
}
