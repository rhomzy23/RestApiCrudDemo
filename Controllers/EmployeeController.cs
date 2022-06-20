using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiCrudDemo.EmployeeData;

namespace RestApiCrudDemo.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeData  _employeeData;
        public EmployeeController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;

        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return  Ok(_employeeData.GetEmployee());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);
            
            if (employee != null)
            {
                return Ok(_employeeData.GetEmployee(id));
            }

            return NotFound($"Employee with {id} that you search is not found");
        }

    }
} 
