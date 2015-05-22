namespace School.Classes
{
    using System;
    
    public enum TeacherDisciplines
    {
        Mathematics, Physics, Chemistry, Biology, Painting, ComputerSciences
    }
    public class Discipline
    {
        private ushort numberOfLectures;
        private ushort numberOfExercises;
        public Discipline(TeacherDisciplines nameOfDiscipline, ushort numOfLectures, ushort numOfExercises)
        {
            this.NameOfDicipline = nameOfDiscipline;
            this.NumberOfLectures = numOfLectures;
            this.NumberOfExercises = numOfExercises;
        }

        public TeacherDisciplines NameOfDicipline { get; set; }

        public ushort NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Lectures cannot be negative number!");
                    }

                    this.numberOfLectures = value;
                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }

        public ushort NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Exercises cannot be negative number!");
                    }

                    this.numberOfExercises = value;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} ", this.NameOfDicipline);
        }
    }
}
