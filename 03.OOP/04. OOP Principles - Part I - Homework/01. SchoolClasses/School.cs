namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private string name;
        private string location;
        private IEnumerable<SchoolClass> classes;

        public School(string name, string location, IEnumerable<SchoolClass> classes)
        {
            this.Name = name;
            this.Location = location;
            this.Classes = classes;
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
        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter a name");
                }
                this.location = value;
            }
        }

        public IEnumerable<SchoolClass> Classes
        { 
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("School's name: {0}\n", this.Name);
            sb.AppendFormat("School's location: {0}\n", string.Join("", this.Location));
            sb.AppendFormat("School's classes:\n{0}\n", string.Join("", this.Classes));
            return sb.ToString();
        }
    }
}
