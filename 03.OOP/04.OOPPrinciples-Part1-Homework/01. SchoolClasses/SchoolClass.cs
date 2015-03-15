namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SchoolClass : ICommentable
    {
        private string comment;
        private IEnumerable<Student> students;
        private IEnumerable<Teacher> teachers;
        private string textID;

        public SchoolClass(IEnumerable<Student> students, IEnumerable<Teacher> teachers, string textID)
        {
            this.Students = students;
            this.Teachers = teachers;
            this.TextID = textID;
        }

        public IEnumerable<Student> Students 
        { 
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
        public IEnumerable<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public string TextID
        {
            get
            {
                return this.textID;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The Text Identifier cannot be null");
                }
                this.textID = value;
            }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.comment))
                {
                    return "No comments yet!";
                }

                return this.comment;
            }
            set { this.comment = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("The identifier of the class: {0}\n", this.TextID);
            sb.AppendFormat("Students in the class:\n{0}\n", string.Join("", this.Students));
            sb.AppendFormat("Teachers in the class:\n{0}\n", string.Join("", this.Teachers));
            return sb.ToString();
        }

    }
}
