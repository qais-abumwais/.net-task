using Employees.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Controllers
{
    [Route("api/sales")]
    [Produces("application/json")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        [HttpPost("set-manager")]
        public Manager SetManager([FromBody] Manager manager)
        {
            Sales sales = new Sales(0.1m, 5000, 6500, "Brain", "B", 500);
            sales.Manager = manager;
            return sales.Manager;
        }

        [HttpGet("calculate-salary")]
        public decimal CalculateSalary()
        {
            Sales sales = new Sales(0.1m, 5000, 6500, "Brain", "B", 500);
            return sales.CalculateSalary();
        }
    }
}
