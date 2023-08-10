using CleanArchitectureConcept_Domain.Entities;
using CleanArchitectureConcept_Infrastructure.DataSeeding;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureConcept_Infrastructure.Persistence.ApplicationDbContext
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

       /*     base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer();*/
           /* base.OnModelCreating(modelBuilder);*/
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
    

