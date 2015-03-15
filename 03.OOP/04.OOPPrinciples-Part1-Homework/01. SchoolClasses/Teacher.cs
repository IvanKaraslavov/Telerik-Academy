namespace School
{

    using System.Collections.Generic;
    using System.Text;

    public class Teacher : People, ICommentable
    {

        private List<Discipline> disciplines;
        Discipline discipline = new Discipline();

        public Teacher(string fullName, int age, string gender, Discipline discipline)
            :this(fullName,age,gender)
        {
            this.discipline = discipline;
        }

        public Teacher(string fullName, int age, string gender)
        {
            this.FullName = fullName;
            this.Age = age;
            this.Gender = gender;
            disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(this.disciplines ?? new List<Discipline>(0));
            }
        }
        public void AddDisciplines(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("----------------------------------------------\n");
            sb.AppendFormat("Teacher's name: {0}\n", this.FullName);
            sb.AppendFormat("Teacher's age: {0}\n", this.Age);
            sb.AppendFormat("Teacher's gender: {0}\n", this.Gender);
            sb.AppendFormat("Teacher's disciplines: \n{0}\n", string.Join("", this.Disciplines));
            return sb.ToString();
        }
    }
}
