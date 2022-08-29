namespace Employees.Models
{
    public class Developer : Employee, Calculation
    {
        private LeadDeveloper leadDeveloper;

        public Developer(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
        }

        public LeadDeveloper LeadDeveloper { get; set; }

        public decimal CalculateSalary()
        {
            return Salary;
        }
    }
}
