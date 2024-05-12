using Calısan_Bodro_Web.Models;
using System.Collections.Generic;

namespace Calısan_Bodro_Web.DataAccess
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> EmployeeGetAll();

    }
}
