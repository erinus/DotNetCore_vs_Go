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
            List<Int32> l = new List<Int32>();
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                l.Add(r.Next());
            }
            return new string[] { "value1", "value2" };
        }
    }
}
