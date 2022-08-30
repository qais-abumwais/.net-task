namespace Employees.Models
{
    public static class DemoEmployeeData
    {
        public static Developer developer = new Developer("Qais", "Maher", 500);
        public static HR hr = new HR("Diana", "Shawabkeh", 500);
        public static LeadDeveloper leadDeveloper = new LeadDeveloper("Ibrahim", "Swaiss", 500);
        public static Manager manager = new Manager(500, "Rasheed", "Rabata", 500);
        public static Sales sales = new Sales(0.1m, 5000, 6500, "Brain", "B", 500);
    }
}
