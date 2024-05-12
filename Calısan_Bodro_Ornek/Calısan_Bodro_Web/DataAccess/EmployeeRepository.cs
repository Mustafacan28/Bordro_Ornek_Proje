using Calısan_Bodro_Web.Contexts;
using Calısan_Bodro_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Calısan_Bodro_Web.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
      

        public async Task<List<Employee>> EmployeeGetAll()
        {
            using (var dbContext = new SpDbContext())
            {
                return await dbContext.Employeies.FromSqlRaw("SpEmployeeList").ToListAsync();
            }
        }

    }
}
