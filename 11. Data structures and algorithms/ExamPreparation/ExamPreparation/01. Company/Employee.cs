namespace Company
{
    using System.Collections.Generic;

    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
            this.Subordians = new List<Employee>();
            this.Salary = 1;
        }

        public string Name { get; set; }

        public List<Employee> Subordians { get; set; }

        public int Salary { get; set; }
    }
}


/*
        public static void DFS(Node<int> root)
        {
            foreach (var child in root.Children)
            {
                if (child.Children.Count != 0)
                {
                    DFS(child);

                    foreach (var subChild in child.Children)
                    {
                        child.Value += subChild.Value;
                        salarySum += subChild.Value;
                    }
                }
                else
                {
                    child.Value = 1;
                    salarySum += 1;
                }
            }
        }
*/
