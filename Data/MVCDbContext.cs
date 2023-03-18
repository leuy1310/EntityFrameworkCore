using EmpoyeeManage.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmpoyeeManage.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
