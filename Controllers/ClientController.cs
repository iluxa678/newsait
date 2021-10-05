using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Client.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        [HttpPost("Adding")]
        public string Information(string str)
        {
            return str;
        }

        [HttpPost("Recording")]
        public string Makinп(string str)
        {
            return str;
        }

        [HttpPost("Appeal")]
        public string Evaluation(string str)
        {
            return str;
        }

        [HttpGet("Conclusion")]
        public string Price(string str)
        {
            return str;
        }

    }
}
