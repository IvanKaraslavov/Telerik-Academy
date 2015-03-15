namespace FirstBeforeLast
{
    //Write a method that from a given array of students finds all students whose first name
    //is before its last name alphabetically.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AllStudents;

    public class FirstBeforeLast
    {

        static void Main()
        {

            Student[] students = new Student[3];
            Student student1 = new Student("Ivan", "Georgiev", 23);
            students[0] = student1;
            Student student2 = new Student("Petur", "Stoyanov", 18);
            students[1] = student2;
            Student student3 = new Student("Georgi", "Ivanov", 34);
            students[2] = student3;

            var result = students.
                Where(st => st.FirstName.CompareTo(st.LastName) < 0)
                .Select(st => st);

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}
