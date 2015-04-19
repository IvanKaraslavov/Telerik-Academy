using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllStudents;

namespace StudentGroups
{
    public class ExtractMarks
    {
        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Problem15(IEnumerable<Student> students)
        {
            var result = students.Where(st => st.FacultyNumber[4] == '0' && st.FacultyNumber[5] == '6');
            Print(result);
        }
    }
}
