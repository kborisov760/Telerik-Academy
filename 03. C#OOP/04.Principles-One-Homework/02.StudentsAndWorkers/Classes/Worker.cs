namespace StudentsAndWorkers.Classes
{
    using System;
    public class Worker : Human
    {
        private const byte WORK_DAYS = 5;

        public Worker(string firstName, string lastName, ushort salary, ushort workDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.WorkHoursePerDay = workDay;
        }

        public ushort WeekSalary { get; set; }
        public ushort WorkHoursePerDay { get; set; }

        public double MoneyPerHour(Worker worker)
        {
            double moneyPerHour = 0;
            moneyPerHour = (WeekSalary / 5) / WorkHoursePerDay;
            return Math.Round(moneyPerHour, 2);
        }

        public override string ToString()
        {
            return String.Format("First name: {0} | Last name: {1} | Salary: {2} | Work hours: {3}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursePerDay);
        }
    }
}
