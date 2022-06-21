using Microsoft.EntityFrameworkCore;

namespace RestApiCrudDemo.Models


{
    public class EmployeeContext: DbContext
    {
    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
    {
        
    }
        public DbSet<Employee> Employees { get; set; }
    }
}
