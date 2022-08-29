using Employees.Models;
using Microsoft.AspNetCore.Mvc;


namespace Employees.Controllers
{
    [Route("api/developer")]
    [Produces("application/json")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        [HttpPost("set-manager")]
        public LeadDeveloper SetManager([FromBody] LeadDeveloper leadDeveloper)
        {
            Developer developer = new Developer("Qais", "Maher", 500);
            developer.LeadDeveloper = leadDeveloper;
            return developer.LeadDeveloper;
        }

        [HttpGet("calculate-salary")]
        public decimal CalculateSalary()
        {
            Developer developer = new Developer(
                "Qais",
                "Maher",
                500
            );
            return developer.CalculateSalary();
        }
    }
}