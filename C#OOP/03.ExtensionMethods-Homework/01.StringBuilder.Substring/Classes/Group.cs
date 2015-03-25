namespace ExtensionMethods.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public enum Department
    {
        Mathematics,
        Physics,
        Biogoly
    }
    public class Group
    {
        public Group(int number, Department depart)
        {
            this.GroupNumber = number;
            this.DepartmentName = depart;
        }

        public int GroupNumber { get; set; }

        public Department DepartmentName { get; set; }
    }
}
