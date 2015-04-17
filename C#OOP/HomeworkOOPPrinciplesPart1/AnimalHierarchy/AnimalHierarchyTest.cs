namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;

    class AnimalHierarchyTest
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Dog("Pesho", 3, Gender.male));
            animals.Add(new Kitten("Kotanka", 1));
            animals.Add(new Dog("Gosho", 5, Gender.male));
            animals.Add(new Frog("Quaki", 3, Gender.female));
            animals.Add(new Tomcat("Murlio", 2));
            animals.Add(new Dog("Sharo", 7, Gender.male));
            animals.Add(new Kitten("Pisanka", 4));
            animals.Add(new Frog("Kekerica", 3, Gender.female));

            
            double average =  Animal.Average(animals);

            Console.WriteLine("Animals average age is: {0}", average);

            foreach (var animal in animals)
            {
                Console.WriteLine("Name: {0}, Age: {1} Gender: {2} - {3}",
                    animal.Name, animal.Age, animal.Sex, animal.ProduceSound());
            }
        }
    }
}
