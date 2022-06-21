using RestApiCrudDemo.Models;

namespace RestApiCrudDemo.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Employee One"
            },

            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Employee Two"
            }
        };
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);

        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public Employee GetEmployee(Guid Id)
        {
            return employees.SingleOrDefault(x => x.Id == Id);
        }

        public List<Employee> GetEmployee()
        {
           return employees;
        }
    }
}
