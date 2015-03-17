namespace StudentsАndWorkers
{
    using System.Text;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, int grade)
            :this(firstName,lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
                
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Student's first name: {0}\n", this.FirstName);
            sb.AppendFormat("Student's last name: {0}\n", this.LastName);
            sb.AppendFormat("Student's marks: {0}\n", string.Join(",", this.Grade));
            return sb.ToString();
        }
    }
}
