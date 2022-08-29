namespace Employees.Models
{
    public class LeadDeveloper : Employee, Calculation
    {
        private Manager manager;

        public LeadDeveloper(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
        }

        public Manager Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public decimal CalculateSalary()
        {
            return Salary;
        }
    }
}
