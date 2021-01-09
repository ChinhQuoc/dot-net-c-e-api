using System.Collections.Generic;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities dbContext = new EmployeeDBEntities())
            {
                return dbContext.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDBEntities dbContext = new EmployeeDBEntities())
            {
                return dbContext.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
