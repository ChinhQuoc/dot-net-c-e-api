using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(EmployeeDBContext dbContext = new EmployeeDBContext())
            {
                return dbContext.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using(EmployeeDBContext dbContext = new EmployeeDBContext())
            {
                return dbContext.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
