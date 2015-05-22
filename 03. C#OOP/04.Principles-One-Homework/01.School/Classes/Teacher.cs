namespace School.Classes
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string fName, string lName)
            : base(fName, lName)
        {
            this.TeacherDiscipline = new List<Discipline>();
        }

        public List<Discipline> TeacherDiscipline { get; set; }

        public void AddDisciplinesForTeacherList(Discipline currentDis)
        {
            TeacherDiscipline.Add(currentDis);
        }

        public static string GetTeacherDisciplinesFromList(List<Discipline> curList)
        {
            StringBuilder outstring = new StringBuilder();
            for (int i = 0; i < curList.Count; i++)
            {
                outstring.Append(curList[i]);
                if (i != curList.Count - 1)
                {
                    outstring.Append(", ");
                }
            }
            return outstring.ToString();
        }
    }
}
