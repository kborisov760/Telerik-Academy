namespace AnimalHierarchy.Classes
{
    using System;
    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("Croak! Croak!");
        }
    }
}
