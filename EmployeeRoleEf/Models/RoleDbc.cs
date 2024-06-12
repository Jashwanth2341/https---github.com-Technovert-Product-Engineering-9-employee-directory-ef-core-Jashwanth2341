using Microsoft.EntityFrameworkCore;
using EmployeeRoleEf.Models;

namespace EmployeeRoleEf
{
    public class RoleDbContext : DbContext
    {
        public RoleDbContext(DbContextOptions<RoleDbContext> options) : base(options)
        {

        }
        public DbSet<Role> roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);
        }
    }

}