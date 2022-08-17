namespace Employees.Models
{
    public class Developer : Employee, Calculation
    {
        private readonly LeadDeveloper leadDeveloper;

        public Developer(LeadDeveloper leadDeveloper, string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
            this.leadDeveloper = leadDeveloper;
        }

        public LeadDeveloper LeadDeveloper => leadDeveloper;

        public double calculateSalary()
        {
            return Salary;
        }
    }
}
