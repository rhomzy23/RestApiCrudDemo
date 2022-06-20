using RestApiCrudDemo.Models;
using System.Collections.Generic; 
namespace RestApiCrudDemo.EmployeeData
using RestApiCrudDemo.Models;

    private List<Employee> employees = new List<Employee>()
    {
        new Employee()
        {
            id = Guid.NewGuid(),
            Name = "Rhomzy"
        },
        new Employee()
        {
            id = Guid.NewGuid(),
            Name = "Employee Number 2"
        },

    };
    public Employee AddEmployee(Employee employee) => throw new NotImplementedException();

    public Employee EditEmployee(Employee employee) => throw new NotImplementedException();

    public Employee GetEmployee(Employee employee) => throw new NotImplementedException();


    }