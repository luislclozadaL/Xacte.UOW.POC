using System;
using System.Collections.Generic;
using System.Text;
using Xacte.Data.Model;

namespace Xacte.Data.Shared.Interfaces
{
    public interface IXacteUOW
    {
        IGenericRepository<Patient> Patients { get; }
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void SaveChanges();
    }
}
