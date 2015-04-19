namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name, bool isMale)
            :base(age, name, true)
        {

        }

        public override string SaySomething()
        {
            return "Tomcat miao, miao, miao...";
        }
    }
}
