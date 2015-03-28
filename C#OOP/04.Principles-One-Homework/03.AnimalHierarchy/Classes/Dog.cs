namespace AnimalHierarchy.Classes
{
    using System;
    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("Wuff! Wuff!");
        }
    }
}
