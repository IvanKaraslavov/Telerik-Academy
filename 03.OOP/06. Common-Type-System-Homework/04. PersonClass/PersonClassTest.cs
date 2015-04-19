namespace PersonClass
{
    using System;
    using System.Collections.Generic;

    public class PersonClassTest
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Pesho", 23));
            people.Add(new Person("Gosho", null));
            people.Add(new Person("Sasho", 19));
            people.Add(new Person("Mira", 99));
            people.Add(new Person("Penka", null));

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
