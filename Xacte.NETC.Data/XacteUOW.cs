using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xacte.Data.Model;
using Xacte.Data.Shared.Interfaces;
using System.Linq;

namespace Xacte.NETC.Data
{
    public class XacteUOW : IXacteUOW
    {
        public IGenericRepository<Patient> Patients { get; }

        public XacteUOW()
        {
            var xacteDbContext = new XacteDbContext();
            Patients = new GenericRepository<Patient>(xacteDbContext);
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

    }
}
