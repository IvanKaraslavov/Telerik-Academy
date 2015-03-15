namespace School
{
    using System;
    using System.Collections.Generic;

    public class SchoolTest
    {
        public static void PrintSchool(IEnumerable<School> schools)
        {
            foreach (var school in schools)
            {
                Console.WriteLine(school);
            }
        }
        public static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan Ivanov", 18, "male", 11));
            students[0].AddMark(6);
            students[0].AddMark(6);
            students.Add(new Student("Georgi Georgiev", 17, "male", 7));
            students[1].AddMark(2);
            students[1].AddMark(2);

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("Cvetana Petrova", 40, "female"));
            Discipline english = new Discipline("English", 60, 30);
            teachers[0].AddDisciplines(english);
            Discipline maths = new Discipline("Maths", 120, 90);
            teachers[0].AddDisciplines(maths);

            List<SchoolClass> classes = new List<SchoolClass>();
            classes.Add(new SchoolClass(students, teachers, "11A"));

            List<School> schools = new List<School>();
            schools.Add(new School("EG Ivan Vazov", "Plovdiv", classes));
            PrintSchool(schools);

        }
    }
}
