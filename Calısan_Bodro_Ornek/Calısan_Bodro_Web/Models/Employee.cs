using Microsoft.EntityFrameworkCore;

namespace Calısan_Bodro_Web.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string IdentificationNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }
    }
}
