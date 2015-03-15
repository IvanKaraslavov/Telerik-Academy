namespace AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
        }

        public override string SaySomething()
        {
            return "Bau, bau, bau...";
        }
    }
}
