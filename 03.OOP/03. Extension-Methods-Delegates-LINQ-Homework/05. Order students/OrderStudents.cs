namespace OrderStudents
{

        //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
        //by first name and last name in descending order.
        //Rewrite the same with LINQ.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AllStudents;

    class OrderStudents
    {
        static void Main()
        {
            Student[] students = new Student[6];
            Student student1 = new Student("Ivan", "Georgiev", 23);
            students[0] = student1;
            Student student2 = new Student("Petur", "Stoyanov", 19);
            students[1] = student2;
            Student student3 = new Student("Georgi", "Ivanov", 34);
            students[2] = student3;
            Student student4 = new Student("Dimitur", "Petrov", 31);
            students[3] = student4;
            Student student5 = new Student("Ivan", "Zaprqnov", 26);
            students[4] = student5;
            Student student6 = new Student("Mariyana", "Koleva", 18);
            students[5] = student6;

            var result = students.
                OrderBy(st => st.FirstName)
                .ThenBy(st => st.LastName);
              

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }

            //Rewrite the same with LINQ.
            //var result1 = from student in students
            //              orderby student.FirstName, student.LastName
            //              select student;

            //foreach (var student in result1)
            //{
            //    Console.WriteLine(student);
            //}
        }
    }
}
