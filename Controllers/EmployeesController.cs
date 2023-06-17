using ASP.NETCore6WebAPICRUDWithEntityFramework_CodeFirstApproach_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore6WebAPICRUDWithEntityFramework_CodeFirstApproach_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
            {
                new Employee{
                    Id = 1,
                    Name = "Jon Doe",
                    FirstName = "Jon",
                    LastName = "Doe",
                    Email = "jon_doe@email.com"
                },
                new Employee{
                    Id = 2,
                    Name = "Will Smith",
                    FirstName = "Will",
                    LastName = "Smith",
                    Email = "will_smith@email.com"
                },
                new Employee{
                    Id = 3,
                    Name = "Allen Shar",
                    FirstName = "Allen",
                    LastName = "Shar",
                    Email = "allen_shar@email.com"
                },
                new Employee{
                    Id = 4,
                    Name = "Baichung Bhuchaia",
                    FirstName = "Baichung",
                    LastName = "Bhuchaia",
                    Email = "baichung_bhuchaia@email.com"
                },


            };
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            
            return Ok(employees);
        }
        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return Ok(employees);
        }
    }
}
