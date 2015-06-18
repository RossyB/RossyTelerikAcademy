namespace AnimalHierarchy
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gender Sex { get; private set; }


        public virtual string ProduceSound()
        {
            return "";
        }

        public static double Average(IEnumerable<Animal> animals)
        {

            return animals.Average(x => x.Age);
        }
    }
}
