namespace PersonClass
{
    using System.Text;

    public class Person
    {
        private byte? age;
        private string name;

        public Person() { }
        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public byte? Age { get; private set; }
        public string Name { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Age != null)
            {
                sb.AppendFormat("Name: {0}\n", this.Name);
                sb.AppendFormat("Age: {0}\n", this.Age);
                return sb.ToString();
            }
            else
            {
                sb.AppendFormat("Name: {0}\n", this.Name);
                sb.AppendFormat("Age: {0}\n", "Unknown");
                return sb.ToString();
            }
        }
    }
}
