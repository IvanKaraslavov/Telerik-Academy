namespace AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, bool isMale)
            : base(age, name, isMale)
        {
        }

        public override string SaySomething()
        {
            return "Kva, kva, kva...";
        }
    }
}
