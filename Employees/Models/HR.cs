namespace Employees.Models
{
    public class HR : Employee, Calculation
    {
        private Manager manager;

        public HR(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
        }

        public Manager Manager { get; set; }

        public decimal CalculateSalary()
        {
            return Salary;
        }
    }
}
