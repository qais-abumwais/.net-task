using Microsoft.AspNetCore.Mvc;
using Employees.Models;

namespace Employees.Controllers
{
    [Route("api/employee")]
    [Produces("application/json")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPost("set-leader")]
        public LeadDeveloper SetManager([FromBody] LeadDeveloper leadDeveloper)
        {
            DemoEmployeeData.developer.LeadDeveloper = leadDeveloper;
            return DemoEmployeeData.developer.LeadDeveloper;
        }

        [HttpGet("calculate-salary")]
        public decimal CalculateSalary()
        {
            return DemoEmployeeData.sales.CalculateSalary(); // Or any employee like Manger, Developer, etc...
        }

        [HttpPost("set-manager")]
        public Manager SetManager([FromBody] Manager manager)
        {
            DemoEmployeeData.sales.Manager = manager; // Or any employee like Manger, etc... except(Developer)
            return DemoEmployeeData.sales.Manager;
        }

    }
}
