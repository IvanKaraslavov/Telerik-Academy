namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;

        public Discipline()
        { }
       
        public Discipline(string name, int numberofLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberofLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter a name");
                }
                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                this.numberOfExercises = value;
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
            sb.AppendFormat("Discipline's name: {0}\n", this.Name);
            sb.AppendFormat("Discipline's number of lectures: {0}\n", this.NumberOfLectures);
            sb.AppendFormat("Discipline's number of exercises: {0}\n", this.NumberOfExercises);
            return sb.ToString();
        }
    }
}
