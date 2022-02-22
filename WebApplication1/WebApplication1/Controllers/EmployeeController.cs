using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {

        private readonly IEmployee _employee;

        private readonly IWebHostEnvironment _env;

        public EmployeeController(IEmployee employee, IWebHostEnvironment env)
        {

            _employee = employee;
            _env = env;
        }

        [HttpGet("GetEmployees")]
        public IActionResult GetAllEmployees()
        {
            var emp = _employee.GetEmployees();
            return Ok(emp);
        } 

        [HttpPost("Create")]
        public string Create([FromBody] Employee employee)
        {
            if (_employee.ExistsAlready(employee))
            {
                return "User Exists ";
            }
            return _employee.CreateEmp(employee);
        }

        [HttpPut("Update")]
        public string Update([FromBody] Employee employee)
        {
            return _employee.Update(employee);
        }

        [HttpDelete("{empupd:int}")]

        public string Delete(int empupd)
        {
            if (!_employee.ExistsAlreadyBasedOnId(empupd))
            {
                return "User Doesn't Exists ";
            }
            return _employee.Delete(empupd);

        }

    }
}
