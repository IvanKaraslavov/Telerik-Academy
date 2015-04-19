using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AllStudents
{
    public class Student
    {
        public Groups group = new Groups();
       

        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private List<int> marks;
        private string phone;
        private string facultyNumber;

        public Student(string firstName, string lastName, int age, string tel, string email, string facultyNumber, Groups group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = tel;
            this.Email = email;
            this.FacultyNumber = facultyNumber;
            this.Age = age;
            this.AttendedGroup = group;
            marks = new List<int>();
        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            
        }

        public Student()
        { 
        }


        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                foreach (var letter in value)
                {
                    if (!Char.IsLetter(letter) && letter != ' ' && letter != '-')
                    {
                        throw new ArgumentException("Invalid name!");
                    }
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                foreach (var letter in value)
                {
                    if (!Char.IsLetter(letter) && letter != ' ' && letter != '-')
                    {
                        throw new ArgumentException("Invalid name!");
                    }
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid age!");
                }

                if (value > 150)
                {
                    throw new ArgumentException();
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!Regex.IsMatch(value.Trim(),
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    throw new ArgumentException("Invalid email!");
                }

                this.email = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (!Regex.IsMatch(value.Trim(), @"\+?[()\d- ]+"))
                {
                    throw new ArgumentException("Invalid phone!");
                }

                this.phone = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                this.facultyNumber = value;
            }
        }

        public Groups AttendedGroup
        {
            get
            {
                return this.group;
            }
            set
            {
                this.group = value;
            }
        }

        public List<int> Marks 
        { 
            get
            {
                return new List<int>(this.marks ?? new List<int> (0));
            }
        }

        public void AddMark(int grade)
        {
            this.marks.Add(grade);
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("First Name: {0} \n", this.firstName);
            sb.AppendFormat("Last Name: {0}\n", this.lastName);
            sb.AppendFormat("Age: {0} \n", this.age);
            sb.AppendFormat("Group Name: {0} \n", this.group.GroupName ?? "Unknown");
            sb.AppendFormat("Group Number: {0}\n", this.group.GroupNumber);
            sb.AppendFormat("Faculty Number: {0}\n", this.facultyNumber);
            sb.AppendFormat("Marks: {0}\n", string.Join(",", this.Marks) ?? "Unknown");
            sb.AppendFormat("E-mail: {0}\n", this.email ?? "Unknown");
            sb.AppendFormat("Phone: {0}\n", this.phone ?? "Unknown");
            return sb.ToString();
        }
    }
}
