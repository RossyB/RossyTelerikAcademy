namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Gender sex)
            : base(name, age, sex) 
        {
        }
        public override string ProduceSound()
        {
            return string.Format("{0} says Myau!", this.Name);
        }
    }
}
