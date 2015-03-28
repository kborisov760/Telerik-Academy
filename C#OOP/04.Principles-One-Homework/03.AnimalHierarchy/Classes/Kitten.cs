namespace AnimalHierarchy.Classes
{
    class Kitten : Cat, ISound
    {
        public Kitten(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.female;
        }
    }
}
