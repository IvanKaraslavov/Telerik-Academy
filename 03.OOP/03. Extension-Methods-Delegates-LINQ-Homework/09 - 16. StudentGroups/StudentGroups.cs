namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AllStudents;
    using StudentGroups;

    public class StudentTest
    {

//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), 
//GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void Main()
        {
            var computerScience = new Groups { GroupName = "Computer Science", GroupNumber = 2 };
            var law = new Groups { GroupName = "Law", GroupNumber = 3 };
            var medicine = new Groups { GroupName = "Medicine", GroupNumber = 1 };

            List<Student> students = new List<Student>
            {
                new Student { FirstName = "Ivan", LastName = "Georgiev", Age = 23, Phone = "0286525835",
                Email = "ivan.georgiev@abv.bg", FacultyNumber = "23340606", AttendedGroup = computerScience},
                new Student { FirstName = "Petur", LastName = "Petrov", Age = 19, Phone = "0881523725",
                Email = "petur_petrov@abv.bg", FacultyNumber = "11111105", AttendedGroup = law},
                new Student { FirstName = "Georgi", LastName = "Stoyanov", Age = 34, Phone = "+359281823526",
                Email = "georgi.stoyanov@gmail.com", FacultyNumber = "23361406", AttendedGroup = medicine},
                new Student { FirstName = "Mariyana", LastName = "Ivanova", Age = 17, Phone = "0891525725",
                Email = "mariyana.ivanova@hotmail.com", FacultyNumber = "12345608", AttendedGroup = computerScience}
            };
            var result = students.Where(st => st.AttendedGroup.GroupNumber == 2).OrderBy(st => st.FirstName).Select(st => st);
            Print(result);

            //Implement the previous using the same query expressed with extension methods.
            //var result1 = StudentGroupsExtensions.FindGroupNumber2(students);
            //Print(result1);

            Console.WriteLine("____________________________Problem 11 ________________________________________");

              //Extract all students that have email in abv.bg.
              

            ExtractStudentsByEmail.Problem11(students);

            Console.WriteLine("____________________________Problem 12 ________________________________________");

            //Extract all students with phones in Sofia.

            ExtractStudentsByPhone.Problem12(students);

            Console.WriteLine("____________________________Problem 13 ________________________________________");

            //Select all students that have at least one mark Excellent (6) into a 
            //new anonymous class that has properties – FullName and Marks.

            ExtractStudentsByMarks.Problem13();

            Console.WriteLine("____________________________Problem 14 ________________________________________");

            //Write down a similar program that extracts the students with exactly two marks "2".

            ExtractStudentsWithTwoMarks.Problem14();

            Console.WriteLine("____________________________Problem 15 ________________________________________");

            //Extract all Marks of the students that enrolled in 2006.
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            ExtractMarks.Problem15(students);
        }
    }
}
