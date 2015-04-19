namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student : People, ICommentable
    {
        private int uniqueClassNumber;
        private List<int> marks;

        public Student(string fullName, int age, string gender, int uniqueClassNumber)
        {
            this.FullName = fullName;
            this.Age = age;
            this.Gender = gender;
            this.UniqueClassNumber = uniqueClassNumber;
            marks = new List<int>();
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The unique class number cannot be 0 or negative number");
                }
                this.uniqueClassNumber = value;
            }
        }
        public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks ?? new List<int>(0));
            }
        }
        public void AddMark(int mark)
        {
            this.marks.Add(mark);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("----------------------------------------------\n");
            sb.AppendFormat("Student's name: {0}\n", this.FullName);
            sb.AppendFormat("Student's age: {0}\n", this.Age);
            sb.AppendFormat("Student's gender: {0}\n", this.Gender);
            sb.AppendFormat("Student's class number: {0}\n", this.uniqueClassNumber);
            sb.AppendFormat("Student's marks: {0}\n", string.Join(",", this.Marks));
            return sb.ToString();
        }
    }
}
