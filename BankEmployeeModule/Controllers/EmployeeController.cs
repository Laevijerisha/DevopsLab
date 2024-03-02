using BankEmployeeModule.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankEmployeeModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<Employee> employees = new List<Employee>();
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }
        [HttpPost]
        public IActionResult PostEmployee(Employee employee)
        {
            employees.Add(employee);
            return Ok (employee);
        }
    }
}
