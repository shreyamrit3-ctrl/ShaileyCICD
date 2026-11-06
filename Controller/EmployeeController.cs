using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Shailey",
                Department = "IT",
                Designation = "Developer",
                Salary = 50000
            },
            new Employee
            {
                Id = 2,
                Name = "Deepa",
                Department = "HR",
                Designation = "HrHead",
                Salary = 65000
            },
            new Employee
            {
                Id = 3,
                Name = "Amit",
                Department = "Finance",
                Designation = "Accountant",
                Salary = 45000
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found");

            return Ok(employee);
        }
    }
}
