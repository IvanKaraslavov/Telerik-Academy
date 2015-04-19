namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;

    public class AnimalHierarchyTest
    {
        public static void Print(IEnumerable<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        static void Main()
        {
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog(3, "Rex", true);
            dogs[1] = new Dog(5, "Charlie", true);
            dogs[2] = new Dog(2, "Rebekah", false);
            Print(dogs);
            Console.WriteLine("-------------------------------------------------");

            Frog[] frogs = new Frog[2];
            frogs[0] = new Frog(1, "Unufri", true);
            frogs[1] = new Frog(7, "Penelopa", false);
            Print(frogs);
            Console.WriteLine("-------------------------------------------------");

            Cat[] cats = new Cat[4];
            cats[0] = new Cat(4, "Penka", false);
            cats[1] = new Cat(10, "Garfield", true);
            cats[2] = new Cat(1, "Robi", true);
            cats[3] = new Cat(9, "Pepi", false);
            Print(cats);
            Console.WriteLine("-------------------------------------------------");

            Kitten[] kittens = new Kitten[4];
            kittens[0] = new Kitten(13, "Mery", false);
            kittens[1] = new Kitten(2, "Lilly", false);
            kittens[2] = new Kitten(8, "Nanny", false);
            kittens[3] = new Kitten(2, "Tedy", false);
            Print(kittens);
            Console.WriteLine("-------------------------------------------------");

            Tomcat[] tomcats = new Tomcat[4];
            tomcats[0] = new Tomcat(9, "Niki", true);
            tomcats[1] = new Tomcat(3, "Bobi", true);
            tomcats[2] = new Tomcat(10, "Goshko", true);
            tomcats[3] = new Tomcat(1, "Vanko", true);
            Print(tomcats);
            Console.WriteLine();
            Console.WriteLine("---------------Average Years---------------");
            Console.WriteLine("Dogs: {0:F2}",Animal.AverageAge(dogs));
            Console.WriteLine("Frogs: {0:F2}", Animal.AverageAge(frogs));
            Console.WriteLine("Cats: {0:F2}", Animal.AverageAge(cats));
            Console.WriteLine("Kittens: {0:F2}", Animal.AverageAge(kittens));
            Console.WriteLine("Tomcats: {0:F2}", Animal.AverageAge(tomcats));

        }
    }
}