using Calısan_Bodro_Web.Business;
using Calısan_Bodro_Web.Contexts;
using Calısan_Bodro_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Calısan_Bodro_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
           _employeeService= employeeService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _employeeService.EmployeeGetAll();
            return Ok(result);
        }
    }

    
}
