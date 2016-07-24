using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestServer.Controllers
{
    [Route("api/values")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
