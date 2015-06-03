using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Http.Results;

namespace PairPark.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        
        [Route("works", Name = "works")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult works()
        {
            return Ok("Api works");
        }

        [Route("authorized", Name = "authorized")]
        [HttpGet]
        [Authorize]
        public IHttpActionResult isAuthenticated()
        {
            return Ok("Authorized");
        }
    }
}
