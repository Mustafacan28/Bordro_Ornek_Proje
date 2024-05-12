using Calısan_Bodro_Web.Models;

namespace Calısan_Bodro_Web.Business
{
    public interface IEmployeeService
    {
        Task<List<Employee>> EmployeeGetAll();

    }
}
