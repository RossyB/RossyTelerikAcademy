namespace Task2
{
    public class Human
    {
        enum Gender { male, female };

        public class Person
        {
            public Gender gender { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public int personNumber { get; set; }
        }
        public void MakePerson(int personNumber)
        {
            Person newPerson = new Person();
            newPerson.age = 0;
            if (personNumber % 2 == 0)
            {
                newPerson.name = "Ivan";
                newPerson.gender = Gender.male;
                newPerson.personNumber = personNumber;
            }
            else
            {
                newPerson.name = "Mimeto";
                newPerson.gender = Gender.female;
                newPerson.personNumber = personNumber;
            }
        }
    }
}
