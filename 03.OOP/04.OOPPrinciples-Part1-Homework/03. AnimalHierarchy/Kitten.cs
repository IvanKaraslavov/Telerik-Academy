using System;
namespace AnimalHierarchy
{
    public class Kitten : Cat, ISound
    {
        public Kitten(int age, string name, bool isMale)
            :base(age, name, false)
        {

        }

        public override string SaySomething()
        {
            return "Kitty miao, miao, miao...";
        }
    }
}
