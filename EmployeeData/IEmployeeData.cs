using RestApiCrudDemo.Models;

namespace RestApiCrudDemo.EmployeeData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployee();

        Employee GetEmployee(Guid Id);

        Employee AddEmployee(Employee employee);

        Employee EditEmployee(Employee employee);

        void DeleteEmployee(Employee employee);
    }
}
