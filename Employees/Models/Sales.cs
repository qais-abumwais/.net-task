namespace Employees.Models
{
    public class Sales : Employee, Calculation
    {
        private readonly double commission;
        private readonly double target;
        private readonly double totalSales;
        private Manager manager;

        public Sales(double commission, double target, double totalSales, string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
            this.commission = commission;
            this.totalSales = totalSales;
            this.target = target;
        }

        public double Commission => commission;
        public double TotalSales => totalSales;
        public double Target => target;
        public Manager Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public double CalculateSalary()
        {
            if(totalSales > target)
            {
                return ((commission / 100) * totalSales) + Salary;
            }

            return Salary;
        }
    }
}
