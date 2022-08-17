namespace Employees.Models
{
    public class LeadDeveloper : Employee, Calculation
    {
        private readonly Manager manager;

        public LeadDeveloper(Manager manager, string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
            this.manager = manager;
        }

        public Manager Manager => manager;

        public double calculateSalary()
        {
            return Salary;
        }
    }
}
