namespace Employees.Models
{
    public class Manager : Employee, Calculation
    {
        private readonly double bouns;
        public Manager(double bouns, string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
            this.bouns = bouns;
        }
        public double Bouns => bouns;

        public double calculateSalary()
        {
            return bouns + Salary;
        }
    }
}
