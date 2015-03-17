using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllStudents;

namespace StudentGroups
{
    public class ExtractStudentsByEmail
    {

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Problem11(IEnumerable<Student> students)
        {
            var result = students.Where(st => st.Email.Substring(st.Email.IndexOf("@") + 1) == "abv.bg")
                .OrderBy(st => st.FirstName).Select(st => st);
            Print(result);
        }
    }
}
