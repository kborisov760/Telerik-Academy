namespace Company
{
    using System;
    using System.Collections.Generic;

    public class Company
    {
        static int salarySum = 0;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

            string bossName = Console.ReadLine();
            var boss = new Employee(bossName);
            employees.Add(bossName, boss);

            for (int i = 1; i < n; i++)
            {
                var name = Console.ReadLine();
                var employee = new Employee(name);

                employees.Add(name, employee);
            }

            for (int i = 0; i < m; i++)
            {
                var currentLine = Console.ReadLine().Split(' ');
                string superior = currentLine[0];

                for (int j = 1; j < currentLine.Length; j++)
                {
                    employees[superior].Subordians.Add(employees[currentLine[j]]);
                }
            }

            salarySum = 0;
            DFS(boss);

            foreach (var item in employees)
            {
                Console.WriteLine(item.Value.Name + " " + item.Value.Salary);
            }

            Console.WriteLine(salarySum);
        }

        public static void DFS(Employee root)
        {
            foreach (var employee in root.Subordians)
            {
                if (employee.Subordians.Count != 0)
                {
                    DFS(employee);
                }
                else
                {
                    salarySum += employee.Salary;
                }

            }

            root.Salary = 0;

            foreach (var subEmployee in root.Subordians)
            {
                root.Salary += subEmployee.Salary;
                salarySum += subEmployee.Salary;
            }
        }
    }
}
