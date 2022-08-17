namespace Employees.Models
{
    public class Sales : Employee, Calculation
    {
        private readonly double commission;
        private readonly double target;
        private readonly double totalSales;
        private readonly Manager manager;

        public Sales(Manager manager, double commission, double target, double totalSales, string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
            this.manager = manager;
            this.commission = commission;
            this.totalSales = totalSales;
            this.target = target;
        }

        public double Commission => commission;
        public double TotalSales => totalSales;
        public double Target => target;
        public Manager Manager => manager;

        public double calculateSalary()
        {
            if(totalSales > target)
            {
                return ((commission / 100) * totalSales) + Salary;
            }

            return Salary;
        }
    }
}
