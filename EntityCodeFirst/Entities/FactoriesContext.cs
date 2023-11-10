using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entities
{
    public class FactoriesContext: DbContext
    {
        public FactoriesContext()
        {
            Database.EnsureCreated();   
        }
        public DbSet<Emploee> Employees { get; set; }
        public DbSet<Facility> Facilities { get; set; }

        public DbSet<Occupation> Occions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EF_CodeFirst;Trusted_Connection=True;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Emploee>().Property(e => e.ID).IsRequired();
            modelBuilder.Entity<Emploee>().Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Emploee>().Property(e => e.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Emploee>().Ignore(e => e.Salary);
            

            modelBuilder.Entity<Facility>().Property(f => f.Id).IsRequired();
            modelBuilder.Entity<Facility>().Property( f => f.Address).IsRequired().HasColumnType("varchar(200)");

            modelBuilder.Entity<Occupation>().Property(o => o.ID).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Occupation>().Property(o => o.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Occupation>().Property(o => o.Grade).IsRequired().HasMaxLength(50); 
        }

    }
}
