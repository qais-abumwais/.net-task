namespace Employees.Models
{
    public class Developer : Employee, Calculation
    {
        private LeadDeveloper leadDeveloper;

        public Developer(string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
        }

        public LeadDeveloper LeadDeveloper
        {
            get { return leadDeveloper; }
            set { leadDeveloper = value; }
        }

        public double CalculateSalary()
        {
            return this.Salary;
        }
    }
}
