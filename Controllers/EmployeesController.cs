using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiCrudDemo.EmployeeData;

namespace RestApiCrudDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeData _employeeData;
        public EmployeesController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        [HttpGet]
        [Route("api/[Controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployees());
        }




    }
}
