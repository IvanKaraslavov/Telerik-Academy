using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllStudents;

namespace StudentGroups
{
    class ExtractStudentsByPhone
    {
        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Problem12(IEnumerable<Student> students)
        {
            var result = students.Where(st => st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592"))
                .Select(st => st);
            Print(result);
        }
    }
}
