using IdentityConfigurationProject01.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityConfigurationProject01.Context
{
    public class AppDbContext : IdentityDbContext
    {
        // constructor  
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        // In program.cs define the context configuration as Service

        public DbSet<Student> Students { get; set; }
        // DbSet is a class from EF that represents a specific entity in data model

        // overriding method OnModelCreating (allow us to configure the way our models will be mapped) :
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "Laura",
                    Email = "lauraandrade@gmail.com",
                    Age = 24,
                    Class = "ASP.NET Core"
                });
        }
    }
}
