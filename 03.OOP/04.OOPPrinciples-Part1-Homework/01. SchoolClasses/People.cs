namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class People : ICommentable
    {
        private string fullName;
        private int age;
        private string gender;
        private string comment;

        public People()
        {

        }
        public People(string fullName, int age, string gender)
        {
            this.FullName = fullName;
            this.Age = age;
            this.Gender = gender;
        }

        protected string FullName { 
            get
            {
                return this.fullName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter a name");
                }
                this.fullName = value;
            }
        }
        protected int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("Enter an age");
                }
                if (value > 120)
                {
                    throw new ArgumentOutOfRangeException("Enter proper age");
                }
                this.age = value;
            }
        }
        protected string Gender 
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("Enter male or female");
                }
                this.gender = value;
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

    }
}
