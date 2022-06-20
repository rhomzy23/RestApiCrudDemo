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
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployee()
        {
           return employees;
        }
    }
}
