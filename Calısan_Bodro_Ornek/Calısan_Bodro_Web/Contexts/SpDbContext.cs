using Calısan_Bodro_Web.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace Calısan_Bodro_Web.Contexts
{
    public class SpDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=Deneme;Database=EmployeePayrolDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employeies { get; set; }
    }
}
