namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private bool isMale;

        public Animal(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Enter a positive number");
                }
                this.age = value;
            }
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

        public bool IsMale 
        { 
            get
            {
                return this.isMale;
            }
            set
            {
                this.isMale = value;
            } 
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }

        public virtual string SaySomething()
        {
            return "Zzz.";
        }

        public override string ToString()
        {
            return String.Format("Hi, I'm {2} - I am {3} years old and I am {1}. {0}",
                this.SaySomething(), this.isMale ? "male" : "female" ,this.Name, this.Age);
        }
    }
}

