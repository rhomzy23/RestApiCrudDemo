using RestApiCrudDemo.Models;

namespace RestApiCrudDemo.EmployeeData
{
    public class SqlEmployeeData : IEmployeeData

    {
        private EmployeeContext _employeeContext;
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
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

        public List<Employee> GetEmployee()
        {
            return _employeeContext.Employees.ToList();
        }

        public Employee GetEmployee(Guid Id)
        {
           var employee = _employeeContext.Employees.Find(Id);
            return employee; 
        }
    }
}
