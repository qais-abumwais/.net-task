namespace Employees.Models
{
    public class LeadDeveloper : Employee, Calculation
    {
        private Manager manager;

        public LeadDeveloper(string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
        }

        public Manager Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public double CalculateSalary()
        {
            return Salary;
        }
    }
}
