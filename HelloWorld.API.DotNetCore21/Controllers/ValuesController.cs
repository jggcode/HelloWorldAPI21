using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.API.DotNetCore21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DateTime DateTime { get; set; }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            if (DateTime == DateTime.MinValue)
            {
                DateTime = DateTime.Now;
            }

            var greeting = new Greeting(DateTime);

            return greeting.GetGreeting() + " The current date and time is: " + DateTime;
        }
    }
}
