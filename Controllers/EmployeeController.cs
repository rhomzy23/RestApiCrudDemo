﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiCrudDemo.EmployeeData;
using RestApiCrudDemo.Models;

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

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeData.AddEmployee(employee);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id, employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);

            if(employee != null)
            {
                _employeeData.DeleteEmployee(employee);
                return Ok();
            }

            return NotFound($"Employee with {id} that you search is not found");



        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditEmployee(Guid id, Employee employee)
        {
            var existingEmployee = _employeeData.GetEmployee(id);
            if (existingEmployee != null)
            {
                employee.Id = existingEmployee.Id;
                _employeeData.EditEmployee(employee);
            }

            return Ok(employee);
    
        }



    }
} 
