namespace StudentsАndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsAndWorkersTest
    {
        public static void Print(IEnumerable<Human> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        static void Main()
        {
            Console.WriteLine("------- Sorted Students -------");

            List<Student> students = new List<Student>();
            students.Add(new Student("Petur", "Petrov",4));
            students.Add(new Student("Ivan", "Georgiev",5));
            students.Add(new Student("Danail", "Ivanov",3));
            students.Add(new Student("Zlatomira", "Usheva",2));
            students.Add(new Student("Mariyana", "Petrova",3));
            students.Add(new Student("Elena", "Goergieva",4));
            students.Add(new Student("Petya", "Koleva",5));
            students.Add(new Student("Iveta", "Dinkova",6));
            students.Add(new Student("Mariyana", "Koleva",6));
            students.Add(new Student("Georgi", "Kurov",6));

            var resultStudents = students.OrderBy(st => st.Grade);
            Print(resultStudents);
            Console.WriteLine("------- Sorted Workers -------");

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Violeta","Violetova", 237M, 8));
            workers.Add(new Worker("Slavi", "Mitrov", 287M, 7));
            workers.Add(new Worker("Momchil", "Momchilov", 137M, 5));
            workers.Add(new Worker("Momchil", "Stepanov", 170M, 4));
            workers.Add(new Worker("Mariyana", "Gosheva", 50M, 2));
            workers.Add(new Worker("Spas", "Goergiev", 123M, 2));
            workers.Add(new Worker("Petya", "Miteva", 251M, 4));
            workers.Add(new Worker("Ico", "Vasilev", 250M, 7));
            workers.Add(new Worker("Tencho", "Ivanov", 290M, 9));
            workers.Add(new Worker("Tanya", "Iordanova", 280M, 8));

            var resultWorkers = workers.OrderByDescending(wk => wk.MoneyPerHour());
            Print(resultWorkers);

            Console.WriteLine("------- Merged Lists -------");

            var human = new List<Human>();
            human.AddRange(students);
            human.AddRange(workers);
            var mergedList = human.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            Print(human);
        }
    }
}
