namespace Employees.Models
{
    public class Sales : Employee, Calculation
    {
        private readonly decimal commission;
        private readonly decimal target;
        private readonly decimal totalSales;
        private Manager manager;

        public Sales(decimal commission, decimal target, decimal totalSales, string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            this.commission = commission;
            this.totalSales = totalSales;
            this.target = target;
        }

        public decimal Commission => commission;
        public decimal TotalSales => totalSales;
        public decimal Target => target;
        public Manager Manager { get; set; }

        public decimal CalculateSalary()
        {
            if(totalSales > target)
            {
                return (commission * totalSales) + Salary;
            }

            return Salary;
        }
    }
}
