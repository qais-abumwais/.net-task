using Employees.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Controllers
{
    [Route("api/hr")]
    [Produces("application/json")]
    [ApiController]
    public class HRController : ControllerBase
    {
        [HttpPost("set-manager")]
        public Manager SetManager([FromBody] Manager manager)
        {
            HR hr = new HR("Diana", "Shawabkeh", 500);
            hr.Manager = manager;
            return hr.Manager;
        }

        [HttpGet("calculate-salary")]
        public decimal CalculateSalary()
        {
            HR hr = new HR("Diana", "Shawabkeh", 500);
            return hr.CalculateSalary();
        }
    }
}
