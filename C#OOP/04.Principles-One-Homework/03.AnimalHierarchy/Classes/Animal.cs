namespace AnimalHierarchy.Classes
{
    public enum Sex
    {
        male, female
    }

    public abstract class Animal
    {
        private int age;
        private string name;
        private Sex sex;

        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public Animal(int age, string name, Sex sex)
            : this(age, name)
        {
            this.Sex = sex;
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public Sex Sex
        {
            get { return sex; }
            protected set { sex = value; }
        }
    }
}
