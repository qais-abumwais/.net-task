namespace Employees.Models
{
    public class HR : Employee, Calculation
    {
        private Manager manager;

        public HR(string firstName, string lastName, double salary) : base(firstName, lastName, salary)
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
