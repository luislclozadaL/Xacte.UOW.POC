using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xacte.Data.Shared.Interfaces;
using Xacte.Services;

namespace Xacte.Web.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XacteController : ControllerBase
    {
        private XacteService _xacteService;

        public XacteController(IXacteUOW xacteUow)
        {
            _xacteService = new XacteService(xacteUow);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_xacteService.GetPatients());
        }
    }
}
