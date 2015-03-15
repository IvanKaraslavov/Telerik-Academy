namespace StudentGroups
{
    //Implement the previous using the same query expressed with extension methods.

    using System.Collections.Generic;
    using System.Linq;
    using AllStudents;
    using StudentGroups;

   public class StudentGroupsExtensions
    {
       public static IEnumerable<Student> FindGroupNumber2(IEnumerable<Student> students)
        {
            var result = students.Where(st => st.AttendedGroup.GroupNumber == 2).OrderBy(st => st.FirstName).Select(st => st);

            return result;
        }
    }
}
