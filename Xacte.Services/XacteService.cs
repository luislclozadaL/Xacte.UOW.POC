using System;
using System.Collections.Generic;
using System.Linq;
using Xacte.Data.Model;
using Xacte.Data.Shared.Interfaces;

namespace Xacte.Services
{
    public class XacteService
    {
        private readonly IXacteUOW _xacteUOW;

        public XacteService(IXacteUOW xacteUow)
        {
            _xacteUOW = xacteUow;
        }

        public List<Patient> GetPatients()
        {
            return _xacteUOW.Patients.ToList().ToList();
        }

    }
}
