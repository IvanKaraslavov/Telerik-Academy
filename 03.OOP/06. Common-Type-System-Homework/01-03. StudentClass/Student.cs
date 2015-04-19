namespace StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int SSN { get; private set; }
        public string Address { get; private set; }
        public string MobilePhone { get; private set; }
        public string Email { get; private set; }
        public string Course { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty { get; private set; }
        public Specialty Specialty { get; private set; }

        public Student() 
        { }

        public Student(string firstName, string middleName, string lastName, int ssn, string address,
            string mobilePhone, string email, string course, University university, Faculty faculty,
            Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            return this.FirstName == student.FirstName &&
                this.MiddleName == student.MiddleName &&
                this.LastName == student.LastName;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.FirstName, this.MiddleName, this.LastName).GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Student's first name: {0}\n", this.FirstName);
            sb.AppendFormat("Student's middle name: {0}\n", this.MiddleName);
            sb.AppendFormat("Student's last name: {0}\n", this.LastName);
            sb.AppendFormat("Student's SSN: {0}\n", this.SSN);
            sb.AppendFormat("Student's address: {0}\n", this.Address);
            sb.AppendFormat("Student's mobile phone: {0}\n", this.MobilePhone);
            sb.AppendFormat("Student's email: {0}\n", this.Email);
            sb.AppendFormat("Student's course: {0}\n", this.Course);
            sb.AppendFormat("Student's specialty: {0}\n", this.Specialty);
            sb.AppendFormat("Student's faculty: {0}\n", this.Faculty);
            sb.AppendFormat("Student's university: {0}\n", this.University);
            return sb.ToString();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone,
                               this.Email, this.Course, this.University, this.Faculty, this.Specialty);
        }

        public int CompareTo(object obj)
        {
            var student = obj as Student;
            if (this.FirstName != student.FirstName)
            {
                return this.FirstName.CompareTo(student.FirstName);
            }
            if (this.MiddleName != student.MiddleName)
            {
                return this.MiddleName.CompareTo(student.MiddleName);
            }
            if (this.LastName != student.LastName)
            {
                return this.LastName.CompareTo(student.LastName);
            }
            if (this.SSN != student.SSN)
            {
                return this.SSN.CompareTo(student.SSN);
            }

            return 0;
        }
    }
}
