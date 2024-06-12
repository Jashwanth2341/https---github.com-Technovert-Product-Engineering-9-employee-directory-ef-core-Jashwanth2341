using EmployeeRoleEf.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeRoleEf
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id);

            base.OnModelCreating(modelBuilder);
        }
    }

}