namespace Employees.Models
{
    public class Manager : Employee, Calculation
    {
        private readonly decimal bouns;
        public Manager(decimal bouns, string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            this.bouns = bouns;
        }
        public decimal Bouns => bouns;

        public decimal CalculateSalary()
        {
            return bouns + Salary;
        }
    }
}
