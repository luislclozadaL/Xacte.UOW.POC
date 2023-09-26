using Microsoft.EntityFrameworkCore;
using Xacte.Data.Model;

namespace Xacte.NETC.Data
{
    public class XacteDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Xacte.UOW.POC;Trusted_Connection=True;TrustServerCertificate=Yes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasKey(ent => ent.Id);
            
        }
    }
}