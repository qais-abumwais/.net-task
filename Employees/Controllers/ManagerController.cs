using Employees.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Controllers
{
    [Route("api/manager")]
    [Produces("application/json")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        [HttpGet("calculate-salary")]
        public decimal CalculateSalary()
        {
            Manager manager = new Manager(500, "Rasheed", "Rabata", 500);
            return manager.CalculateSalary();
        }
    }
}
