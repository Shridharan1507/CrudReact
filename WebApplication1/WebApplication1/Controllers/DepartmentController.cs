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
    public class DepartmentController : Controller
    {

        private readonly IDepartment _employee;

        private readonly IWebHostEnvironment _env;

        public DepartmentController(IDepartment employee, IWebHostEnvironment env)
        {

            _employee = employee;
            _env = env;
        }

        [HttpGet("GetDepartments")]
        public IActionResult GetDepartments()
        {
            var emp = _employee.GetDepartments();
            return Ok(emp);
        }

        [HttpPost("Create")]
        public string Create([FromBody] Department employee)
        {
            if (_employee.ExistsAlready(employee))
            {
                return "User Exists ";
            }
            return _employee.CreateDep(employee);
        }

        [HttpPut("Update")]
        public string Update([FromBody] Department employee)
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
