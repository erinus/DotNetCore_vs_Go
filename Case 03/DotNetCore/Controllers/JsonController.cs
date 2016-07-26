using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestServer.Controllers
{
    [Route("api")]
    public class JsonController : Controller
    {
        // GET api/json
        [HttpGet]
        [Route("json")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
