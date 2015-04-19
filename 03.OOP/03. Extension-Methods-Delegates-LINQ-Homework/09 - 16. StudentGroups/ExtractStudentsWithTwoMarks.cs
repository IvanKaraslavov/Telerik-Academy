using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllStudents;

namespace StudentGroups
{
    public class ExtractStudentsWithTwoMarks
    {
        private static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Problem14()
        {
            var computerScience = new Groups { GroupName = "Computer Science", GroupNumber = 2 };
            var law = new Groups { GroupName = "Law", GroupNumber = 3 };
            var medicine = new Groups { GroupName = "Medicine", GroupNumber = 1 };

            Student[] students = new Student[3];
            Student student1 = new Student
            ("Ivan", "Georgiev", 23, "0286525835", "ivan.georgiev@abv.bg", "4", computerScience);
            student1.AddMark(6);
            student1.AddMark(5);
            student1.AddMark(4);
            students[0] = student1;
            Student student2 = new Student
            ("Petur", "Petrov", 19, "0881523725", "petur_petrov@abv.bg", "5", law
            );
            student2.AddMark(3);
            student2.AddMark(3);
            student2.AddMark(4);
            students[1] = student2;
            Student student3 = new Student
            ("Georgi", "Stoyanov", 34, "+359281823526", "georgi.stoyanov@gmail.com", "5", medicine
            );
            student3.AddMark(6);
            student3.AddMark(6);
            students[2] = student3;

            var result = students.Where(st => st.Marks.Count() == 2).Select(st => st);

            Print(result);

        }
    }
}
