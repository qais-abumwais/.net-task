using Employees.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Controllers
{
    [Route("api/lead-developer")]
    [Produces("application/json")]
    [ApiController]
    public class LeadDerveloperController : ControllerBase
    {
        [HttpPost("set-manager")]
        public Manager SetManager([FromBody] Manager manager)
        {
            LeadDeveloper leadDeveloper = new LeadDeveloper("Ibrahim", "Swaiss", 500);
            leadDeveloper.Manager = manager;
            return leadDeveloper.Manager;
        }

        [HttpGet("calculate-salary")]
        public decimal CalculateSalary()
        {
            LeadDeveloper leadDeveloper = new LeadDeveloper("Diana", "Swaiss", 500);
            return leadDeveloper.CalculateSalary();
        }
    }
}
