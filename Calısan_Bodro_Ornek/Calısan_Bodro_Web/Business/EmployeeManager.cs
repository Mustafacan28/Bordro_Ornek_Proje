using Calısan_Bodro_Web.Contexts;
using Calısan_Bodro_Web.DataAccess;
using Calısan_Bodro_Web.Models;

namespace Calısan_Bodro_Web.Business
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository) 
        {
          _employeeRepository= employeeRepository;
        }

        public async Task<List<Employee>> EmployeeGetAll()
        {
            return await _employeeRepository.EmployeeGetAll();
        }

    }
}
