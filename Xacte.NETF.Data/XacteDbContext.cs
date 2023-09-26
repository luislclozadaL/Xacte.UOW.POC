using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xacte.Data.Model;

namespace Xacte.NETF.Data
{
    public class XacteDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public XacteDbContext() : base("Server=.;Database=Xacte.UOW.POC;Trusted_Connection=True")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasKey(prop => prop.Id);
        }
    }
}
