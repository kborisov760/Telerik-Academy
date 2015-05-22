namespace School.Classes.Generators
{
    /// <summary>
    /// Public class used to generate ID for students and classes
    /// Only classes that use specified namespace can use these generators
    /// </summary>
    
    public class IdGenerator
    {
        private static uint nextStudentId = 1;
        private static uint nextClassId = 1;

        public static uint GenerateStudentID()
        {
            return (nextStudentId++);
        }

        public static string GenerateClassID()
        {
            return (nextClassId++).ToString();
        }
    }
}
