﻿using ASP.NETCore6WebAPICRUDWithEntityFramework_CodeFirstApproach_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCore6WebAPICRUDWithEntityFramework_CodeFirstApproach_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesDBController : ControllerBase
    {
       
        private readonly DataContext _context;
        public EmployeesDBController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return Ok(await _context.Employees.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Employee>>> Get(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return BadRequest("Employee Not Found !!");
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(Employee request)
        {
            var employee = await _context.Employees.FindAsync(request.Id);
            if (employee == null)
                return BadRequest("Employee Not Found");
            employee.Name = request.Name;
            employee.FirstName = request.FirstName;
            employee.LastName = request.LastName;
            employee.Email = request.Email;
            await _context.SaveChangesAsync();
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Employee>>> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return BadRequest("Employee Not Found");
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return Ok(await _context.Employees.ToListAsync());
        }
    }
}
