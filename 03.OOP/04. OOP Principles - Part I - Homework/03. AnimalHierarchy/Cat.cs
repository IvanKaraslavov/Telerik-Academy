namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {

        public Cat(int age, string name, bool isMale)
            :base(age, name, isMale)
        {
        }

        public override string SaySomething()
        {
            return "Miao, miao, miao...";
        }
    }
}
