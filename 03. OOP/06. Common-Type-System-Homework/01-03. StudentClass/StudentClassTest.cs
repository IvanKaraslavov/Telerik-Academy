using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public class StudentClassTest
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Mariyana", "Petrova", "Koleva", 1234, "some address",
                "0888888888", "mariyanakoleva@gmail.com", "Informatics",
                University.UniversityOfEdinburgh, Faculty.ComputerScience, Specialty.GraphicDesign));
            students.Add(new Student("Ivan", "Ivanov", "Georgiev", 1234, "some address",
                "0899999999", "ivanIvanov@gmail.com", "Informatics",
                University.UniversityOfEdinburgh, Faculty.ComputerScience, Specialty.SoftwareEngeneering));

            Student clonedStudent = (Student)students[0].Clone();
            Console.WriteLine("First student: ");
            Console.WriteLine(students[0]);
            Console.WriteLine("Second student: ");
            Console.WriteLine(students[1]);
            Console.WriteLine("Cloned student: ");
            Console.WriteLine(clonedStudent);

            if (!students[1].Equals(clonedStudent) && students[0] == clonedStudent)
            {
                Console.WriteLine(" Cloning is successful!\n");
            }
            else if (students[0] != clonedStudent)
            {
                Console.WriteLine("Cloning is not successful!\n");
            }

            Console.WriteLine("Comparing: ");
            Console.WriteLine("Student 1 and Cloned student: {0}", students[0].CompareTo(clonedStudent));
            Console.WriteLine("Student 2 and Cloned student: {0}", students[1].CompareTo(clonedStudent));
        }
    }
}
