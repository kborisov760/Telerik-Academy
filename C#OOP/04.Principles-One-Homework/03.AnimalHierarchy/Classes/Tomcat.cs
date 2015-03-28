namespace AnimalHierarchy.Classes
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.male;
        }
    }
}
