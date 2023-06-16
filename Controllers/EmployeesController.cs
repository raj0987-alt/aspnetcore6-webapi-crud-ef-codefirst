using ASP.NETCore6WebAPICRUDWithEntityFramework_CodeFirstApproach_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore6WebAPICRUDWithEntityFramework_CodeFirstApproach_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Jon Doe",
                    FirstName = "Jon",
                    LastName = "Doe",
                    Email = "john_doe@email.com"
                }
            };
            return Ok(employees);
        }
    }
}
