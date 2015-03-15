namespace AgeRange
{

    //Write a LINQ query that finds the first name and last name of all students with
    //age between 18 and 24.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AllStudents;

    public class AgeRange
    {
        static void Main()
        {

            Student[] students = new Student[3];
            Student student1 = new Student("Ivan", "Georgiev", 23);
            students[0] = student1;
            Student student2 = new Student("Petur", "Stoyanov", 19);
            students[1] = student2;
            Student student3 = new Student("Georgi", "Ivanov", 34);
            students[2] = student3;

            var result = students.
                Where(st => st.Age > 18 && st.Age < 24)
                .Select(st => st);

            foreach (var student in result)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

        }
    }
}
