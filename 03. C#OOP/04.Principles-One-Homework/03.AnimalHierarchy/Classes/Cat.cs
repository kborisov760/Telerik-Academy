namespace AnimalHierarchy.Classes
{
    using System;
    public abstract class Cat : Animal, ISound
    {
        public Cat(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public Cat(int age, string name)
            : base(age, name)
        {
        }


        public void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
