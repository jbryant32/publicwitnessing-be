using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWitnessingApi.Controllers
{
    [ApiController]
    [Route("api/admin")]
    public class AdminController
    {
        public AdminController()
        {

        }

        [HttpPost("new publisher")]
        public ActionResult Post([FromBody] object body) {

            return new OkResult();
        }
    }
}
