using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Xacte.Data.Shared.Interfaces;
using Xacte.Services;

namespace Xacte.Web.NETF.Controllers
{
    public class XacteController : ApiController
    {
        private XacteService _xacteService;

        public XacteController(IXacteUOW xacteUow)
        {
            _xacteService = new XacteService(xacteUow);
        }

        public IHttpActionResult Get()
        {
            return Ok(_xacteService.GetPatients());
        }
    }
}
