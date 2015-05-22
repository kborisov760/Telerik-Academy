namespace School.Classes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class School
    {
        private List<SchoolClass> classes;

        public School(string name)
        {
            this.SchoolName = name;
            this.classes = new List<SchoolClass>();
        }

        public string SchoolName { get; set; }
        public void AddClassToSchool(SchoolClass currentClass)
        {
            classes.Add(currentClass);
        }

        public SchoolClass GetClassByID(string iD)
        {
            var classById = classes.First(x => x.ClassID.Equals(iD));
            return (SchoolClass)classById;
        }

        public override string ToString()
        {
            return this.SchoolName;
        }
    }
}
